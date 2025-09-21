import React from "react";
import logo from "../biblioteca_logo.png"; 
import { Link } from "react-router-dom";

function Navbar() {
  return (
    <nav style={{
      display: "flex",
      justifyContent: "space-between",
      alignItems: "center",
      background: "#eeeae7",  
      padding: "10px 10px",
      color: "#2e6417",
      boxShadow: "0 2px 5px rgba(0,0,0,0.1)"
    }}>
      <div style={{ display: "flex", alignItems: "center" }}>
        <img 
          src={logo} 
          alt="Biblioteca Logo" 
          style={{ height: "80px", maxHeight: "80px", marginRight: "15px" }} 
        />
        <span style={{ fontSize: "26px", fontWeight: "bold" }}>Biblioteca</span>
      </div>

      <div style={{ display: "flex", gap: "15px" }}>
        <a href="/" style={linkStyle}>Home</a>
        <Link to="/library" style={linkStyle}>Library</Link>
        <a href="/about" style={linkStyle}>About</a>


      </div>
    </nav>
  );
}

const linkStyle = {
  color: "#2e6417",
  textDecoration: "none",
  fontSize: "18px",
  fontWeight: "500"
};

export default Navbar;
