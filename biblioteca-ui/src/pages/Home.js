import React from "react";
import { Link } from "react-router-dom";

function Home() {
  return (
    <div style={{
    
      textAlign: "center",
      backgroundImage: "linear-gradient(rgba(222, 228, 219, 0.85), rgba(40, 91, 41, 0.85)), url('/images/librar.webp')",
      backgroundSize: "cover",
      backgroundPosition: "center",
      color: "white",
      minHeight: "80vh",
      display: "flex",
      flexDirection: "column",
      alignItems: "center",
      justifyContent: "center"
    }}>
      <h1 style={{
  fontSize: "48px",
  
  textShadow: "2px 2px 6px rgba(0,0,0,0.4)"
}}>
  Welcome to <span style={{ color: "#e2a9f1", textShadow: "0px 0px 8px rgb(0, 0, 0)" }}>Biblioteca</span>
</h1>


      <p style={{
        fontSize: "20px",
        marginTop: "20px",
        maxWidth: "600px",
        lineHeight: "1.6"
      }}>
        Your personal digital library. <br />
        Browse books, explore authors, and enjoy reading anywhere, anytime.
      </p>

       <Link to="/library" style={{
        marginTop: "30px",
        padding: "12px 28px",
        fontSize: "18px",
        border: "none",
        borderRadius: "8px",
        backgroundColor: "#e2a9f1",
        color: "#2e6417",
        fontWeight: "bold",
        cursor: "pointer",
        boxShadow: "0 4px 10px rgba(0,0,0,0.3)",
        textDecoration: "none",
        display: "inline-block",
        transition: "all 0.3s ease"
      }}>
        📖 Explore Library
      </Link>
    </div>
  );
}

export default Home;