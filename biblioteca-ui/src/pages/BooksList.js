import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";

function BooksList() {
  const [books, setBooks] = useState([]);
  const [search, setSearch] = useState("");
  const [query, setQuery] = useState("");

  useEffect(() => {
    fetch("http://localhost:5043/api/Books")
      .then(res => res.json())
      .then(data => setBooks(data))
      .catch(err => console.error("Error fetching books:", err));
  }, []);

  const filteredBooks = books.filter(
    b =>
      b.title.toLowerCase().includes(query.toLowerCase()) ||
      b.author.toLowerCase().includes(query.toLowerCase())
  );

  const handleSearch = () => {
    setQuery(search);
  };

  return (
    <div style={{ padding: "20px" }}>
      {/* Arama */}
      <div style={{ marginBottom: "20px" }}>
        <input
          type="text"
          placeholder="Search by title or author"
          value={search}
          onChange={(e) => setSearch(e.target.value)}
          style={{ padding: "6px", marginRight: "8px", width: "250px" }}
        />
        <button
          onClick={handleSearch}
          style={{
            padding: "6px 14px",
            background: "#2e6417",
            color: "white",
            border: "none",
            borderRadius: "4px"
          }}
        >
          Search
        </button>
      </div>

      {/* Kitap Kartları */}
      <div
        style={{
          display: "grid",
          gridTemplateColumns: "repeat(auto-fill, minmax(250px, 1fr))",
          gap: "20px"
        }}
      >
        {filteredBooks.map(book => (
          <div
            key={book.id}
            style={{
              border: "1px solid #ddd",
              borderRadius: "8px",
              padding: "15px",
              background: "#fafafa",
              boxShadow: "0 2px 5px rgba(0,0,0,0.1)"
            }}
          >
            <h3 style={{ margin: "0 0 10px 0", color: "#2e6417" }}>{book.title}</h3>
            <p style={{ margin: "0 0 10px 0", fontStyle: "italic" }}>{book.author}</p>

            {book.coverImage ? (
              <img
                src={`http://localhost:5043/${book.coverImage}`}
                alt={book.title}
                style={{ width: "100%", borderRadius: "4px" }}
              />
            ) : (
              <div
                style={{
                  width: "100%",
                  height: "150px",
                  background: "#eee",
                  display: "flex",
                  alignItems: "center",
                  justifyContent: "center",
                  borderRadius: "4px"
                }}
              >
                No Cover
              </div>
            )}

            {/* ✅ View Details butonu */}
            <Link to={`/books/${book.id}`}>
              <button
                style={{
                  marginTop: "10px",
                  padding: "6px 12px",
                  background: "#2e6417",
                  color: "white",
                  border: "none",
                  borderRadius: "4px",
                  cursor: "pointer"
                }}
              >
                View Details
              </button>
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
}

export default BooksList;
