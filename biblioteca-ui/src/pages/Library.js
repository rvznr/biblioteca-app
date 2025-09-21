import React, { useState, useEffect } from "react";
import BooksList from "./BooksList";

function Library() {
  const [activePanel, setActivePanel] = useState(null);

  const [title, setTitle] = useState("");
  const [author, setAuthor] = useState("");
  const [genre, setGenre] = useState("");
  const [publisher, setPublisher] = useState("");
  const [summary, setSummary] = useState("");
  const [coverFile, setCoverFile] = useState(null); 

  const [editId, setEditId] = useState("");

  const [books, setBooks] = useState([]);
  const [selectedIds, setSelectedIds] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5043/api/Books")
      .then(res => res.json())
      .then(data => setBooks(data));
  }, []);

  const addBook = async () => {
    let coverPath = "";

    if (coverFile) {
      const formData = new FormData();
      formData.append("file", coverFile);

      const uploadRes = await fetch("http://localhost:5043/api/Upload", {
        method: "POST",
        body: formData
      });

      if (uploadRes.ok) {
        const data = await uploadRes.json();
        coverPath = data.filePath; 
      }
    }

    const res = await fetch("http://localhost:5043/api/Books", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({
        title, author, genre, publisher, summary, coverImage: coverPath
      })
    });
    if (res.ok) {
      alert("Book added!");
      setTitle(""); setAuthor(""); setGenre(""); setPublisher(""); setSummary(""); setCoverFile(null);
      setActivePanel(null); 
      window.location.reload();
    }
  };

  const updateBook = async () => {
    if (!editId) return alert("Select a book to edit!");
    const res = await fetch(`http://localhost:5043/api/Books/${editId}`, {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ id: editId, title, author, genre, publisher, summary, coverImage: "" })
    });
    if (res.ok) {
      alert("Book updated!");
      setActivePanel(null);
      window.location.reload();
    }
  };

  const deleteBooks = async () => {
    for (let id of selectedIds) {
      await fetch(`http://localhost:5043/api/Books/${id}`, { method: "DELETE" });
    }
    alert("Selected books deleted!");
    setActivePanel(null);
    window.location.reload();
  };

  const toggleSelect = (id) => {
    setSelectedIds(prev =>
      prev.includes(id) ? prev.filter(x => x !== id) : [...prev, id]
    );
  };

  return (
    <div style={{ padding: "20px" }}>
      <h2> My Library</h2>

      <div style={{ marginBottom: "20px" }}>
        <button onClick={() => setActivePanel("add")} style={btnStyle}>➕ Add</button>
        <button onClick={() => setActivePanel("edit")} style={btnStyle}>✏️ Edit</button>
        <button onClick={() => setActivePanel("delete")} style={btnStyle}>❌ Delete</button>
        <button onClick={() => setActivePanel("search")} style={btnStyle}>🔍 Search</button>
      </div>

      {activePanel === "add" && (
        <div style={panelStyle}>
          <div style={{ display:"flex", justifyContent:"space-between", alignItems:"center" }}>
            <h3>Add Book</h3>
            <button onClick={() => setActivePanel(null)} style={closeBtn}>❌</button>
          </div>

          <input placeholder="Title" style={inputStyle} value={title} onChange={e => setTitle(e.target.value)} />
          <input placeholder="Author" style={inputStyle} value={author} onChange={e => setAuthor(e.target.value)} />
          <input placeholder="Genre" style={inputStyle} value={genre} onChange={e => setGenre(e.target.value)} />
          <input placeholder="Publisher" style={inputStyle} value={publisher} onChange={e => setPublisher(e.target.value)} />
          <textarea placeholder="Summary" style={{ ...inputStyle, height:"80px" }} value={summary} onChange={e => setSummary(e.target.value)} />

          <input 
            type="file" 
            accept=".jpg,.jpeg" 
            style={inputStyle}
            onChange={e => setCoverFile(e.target.files[0])} 
          />

          <button onClick={addBook} style={btnStyle}>Save</button>
        </div>
      )}

      {activePanel === "edit" && (
        <div style={panelStyle}>
          <div style={{ display:"flex", justifyContent:"space-between", alignItems:"center" }}>
            <h3>Edit Book</h3>
            <button onClick={() => setActivePanel(null)} style={closeBtn}>❌</button>
          </div>
          <select style={inputStyle} onChange={e => setEditId(e.target.value)}>
            <option value="">-- Select Book --</option>
            {books.map(b => (
              <option key={b.id} value={b.id}>{b.title} ({b.author})</option>
            ))}
          </select>
          <input placeholder="New Title" style={inputStyle} value={title} onChange={e => setTitle(e.target.value)} />
          <input placeholder="New Author" style={inputStyle} value={author} onChange={e => setAuthor(e.target.value)} />
          <input placeholder="New Genre" style={inputStyle} value={genre} onChange={e => setGenre(e.target.value)} />
          <input placeholder="New Publisher" style={inputStyle} value={publisher} onChange={e => setPublisher(e.target.value)} />
          <textarea placeholder="New Summary" style={{ ...inputStyle, height:"80px" }} value={summary} onChange={e => setSummary(e.target.value)} />
          <button onClick={updateBook} style={btnStyle}>Update</button>
        </div>
      )}

      {activePanel === "delete" && (
        <div style={panelStyle}>
          <div style={{ display:"flex", justifyContent:"space-between", alignItems:"center" }}>
            <h3>Delete Books</h3>
            <button onClick={() => setActivePanel(null)} style={closeBtn}>❌</button>
          </div>
          {books.map(b => (
            <div key={b.id}>
              <input type="checkbox" onChange={() => toggleSelect(b.id)} checked={selectedIds.includes(b.id)} />
              {b.title} ({b.author})
            </div>
          ))}
          <button onClick={deleteBooks} style={{ ...btnStyle, marginTop:"10px" }}>Delete Selected</button>
        </div>
      )}

      {activePanel === "search" && (
        <div style={panelStyle}>
          <div style={{ display:"flex", justifyContent:"space-between", alignItems:"center" }}>
            <h3>Search</h3>
            <button onClick={() => setActivePanel(null)} style={closeBtn}>❌</button>
          </div>
          <input placeholder="Search by title or author" style={inputStyle} />
          <button style={btnStyle}>Search</button>
        </div>
      )}

      <BooksList />
    </div>
  );
}

const btnStyle = {
  marginRight: "10px",
  padding: "6px 12px",
  background: "#2e6417",
  color: "white",
  border: "none",
  borderRadius: "4px",
  cursor: "pointer"
};
const panelStyle = { marginBottom: "20px", padding: "15px", border: "1px solid #ccc", borderRadius: "6px", background: "#f9f9f9" };
const inputStyle = { display: "block", margin: "8px 0", padding: "6px", width: "250px" };
const closeBtn = { background:"transparent", border:"none", fontSize:"18px", cursor:"pointer", color:"#444" };

export default Library;
