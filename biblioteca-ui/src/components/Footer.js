import React from "react";

function Footer() {
  return (
    <footer style={{
      backgroundColor: "#eeeae7", //#e2a9f1
      color: "e2a9f1",
      padding: "5px",
      textAlign: "center"
    }}>
      <p style={{ margin: "5px 0" }}>
        © {new Date().getFullYear()} Biblioteca. All rights reserved.
      </p>
      <p style={{ margin: "5px 0", fontSize: "14px" }}>
        Contact: <a href="mailto:ravzasisiknur@gmail.com" style={{ color: "#2e6417", textDecoration: "none" }}>
          ravzasisiknur@gmail.com
        </a>
      </p>
      <p style={{ margin: "5px 0", fontSize: "14px" }}>
        Developed with ❤️ by Ravza Nur Şişik
      </p>
    </footer>
  );
}

export default Footer;
