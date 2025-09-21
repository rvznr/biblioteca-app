import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

function BookDetail() {
  const { id } = useParams();
  const [book, setBook] = useState(null);
  const [loading, setLoading] = useState(true);

  const [rating, setRating] = useState(0);
  const [favoriteQuote, setFavoriteQuote] = useState("");
  const [notes, setNotes] = useState("");
  const [saving, setSaving] = useState(false);
  const [editMode, setEditMode] = useState(false);

  useEffect(() => {
    fetch(`http://localhost:5043/api/Books/${id}`)
      .then(res => res.json())
      .then(data => {
        setBook(data);
        setRating(data.rating || 0);
        setFavoriteQuote(data.favoriteQuote || "");
        setNotes(data.notes || "");
        setLoading(false);
      })
      .catch(err => {
        console.error("Error fetching book:", err);
        setLoading(false);
      });
  }, [id]);

  const handleSave = () => {
    if (!book) return;
    setSaving(true);

    const updatedBook = {
      ...book,
      rating,
      favoriteQuote,
      notes
    };

    fetch(`http://localhost:5043/api/Books/${id}`, {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(updatedBook)
    })
      .then(res => {
        if (!res.ok) throw new Error("Failed to update");
        return res.json();
      })
      .then(data => {
        setBook(data);
        alert("✅ Saved successfully!");
        setEditMode(false); // Kaydettikten sonra tekrar okuma moduna dön
      })
      .catch(err => {
        console.error("Error saving book:", err);
        alert("❌ Save failed");
      })
      .finally(() => setSaving(false));
  };

const handleCoverUpload = async (e) => {
  const file = e.target.files[0];
  if (!file) return;

  console.log("Uploading for book id:", id); // 🔍 debug
  console.log("Full URL:", `http://localhost:5043/api/Books/${id}/upload-cover`);

  const formData = new FormData();
  formData.append("file", file);

  try {
    const res = await fetch(`http://localhost:5043/api/Books/${id}/upload-cover`, {
      method: "POST",
      body: formData
    });
    if (!res.ok) throw new Error("Upload failed");
    const data = await res.json();
    setBook({ ...book, coverImage: data.filePath });
    alert("✅ Cover uploaded!");
  } catch (err) {
    console.error("Error uploading cover:", err);
    alert("❌ Upload failed");
  }
};

  if (loading) return <p style={{ padding: "20px" }}>Loading...</p>;
  if (!book) return <p style={{ padding: "20px" }}>Book not found.</p>;

  return (
    <div style={{ padding: "40px", maxWidth: "800px", margin: "0 auto" }}>
      <h2 style={{ color: "#2e6417" }}>{book.title}</h2>
      <p><strong>Author:</strong> {book.author}</p>
      <p><strong>Genre:</strong> {book.genre}</p>
      <p><strong>Publisher:</strong> {book.publisher}</p>
      <p><strong>Summary:</strong> {book.summary}</p>

      {book.coverImage ? (
        <img
          src={`http://localhost:5043/${book.coverImage}`}
          alt={book.title}
          style={{ maxWidth: "200px", marginTop: "20px", borderRadius: "8px" }}
        />
      ) : (
        <p style={{ marginTop: "20px", fontStyle: "italic" }}>No cover uploaded</p>
      )}

      {/* 📂 Kapak yükleme input */}
      <div style={{ marginTop: "10px" }}>
        <input type="file" accept="image/*" onChange={handleCoverUpload} />
      </div>

      <hr style={{ margin: "30px 0" }} />

      <h3>📖 Your Notes</h3>

      {editMode ? (
        <>
          {/* ⭐ Rating seçimi */}
          <div style={{ marginBottom: "15px" }}>
            <strong>Rating:</strong>{" "}
            {[1,2,3,4,5].map(star => (
              <span
                key={star}
                style={{
                  fontSize: "24px",
                  cursor: "pointer",
                  color: star <= rating ? "gold" : "#ccc"
                }}
                onClick={() => setRating(star)}
              >
                ★
              </span>
            ))}
          </div>

          {/* Favorite Quote */}
          <div style={{ marginBottom: "15px" }}>
            <label><strong>Favorite Quote:</strong></label>
            <textarea
              value={favoriteQuote}
              onChange={(e) => setFavoriteQuote(e.target.value)}
              rows="2"
              style={{ width: "100%", padding: "8px", marginTop: "6px" }}
            />
          </div>

          {/* Notes */}
          <div style={{ marginBottom: "15px" }}>
            <label><strong>Notes:</strong></label>
            <textarea
              value={notes}
              onChange={(e) => setNotes(e.target.value)}
              rows="4"
              style={{ width: "100%", padding: "8px", marginTop: "6px" }}
            />
          </div>

          {/* Save */}
          <button
            onClick={handleSave}
            disabled={saving}
            style={{
              padding: "10px 20px",
              background: "#2e6417",
              color: "white",
              border: "none",
              borderRadius: "5px",
              cursor: "pointer",
              marginRight: "10px"
            }}
          >
            {saving
              ? "Saving..."
              : (book.notes || book.favoriteQuote || book.rating ? "Update" : "Save")}
          </button>

          {/* Cancel */}
          <button
            onClick={() => setEditMode(false)}
            style={{
              padding: "10px 20px",
              background: "#777",
              color: "white",
              border: "none",
              borderRadius: "5px",
              cursor: "pointer"
            }}
          >
            Cancel
          </button>
        </>
      ) : (
        <>
          <p><strong>Rating:</strong> {book.rating ? "⭐".repeat(book.rating) : "—"}</p>
          <p><strong>Favorite Quote:</strong> {book.favoriteQuote || "—"}</p>
          <p><strong>Notes:</strong> {book.notes || "—"}</p>
          <button
            onClick={() => setEditMode(true)}
            style={{
              padding: "8px 16px",
              background: "#444",
              color: "white",
              border: "none",
              borderRadius: "5px",
              cursor: "pointer"
            }}
          >
            ✏️ Edit
          </button>
        </>
      )}
    </div>
  );
}

export default BookDetail;
