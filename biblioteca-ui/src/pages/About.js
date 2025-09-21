import React from "react";

function About() {
  return (
    <div style={{
      padding: "20px ",
      maxWidth: "900px",
      margin: "0 auto",
      lineHeight: "1.8",
      fontFamily: "Arial, sans-serif",
      color: "#333"
    }}>
      {/* Başlık */}
      <h2 style={{
        fontSize: "25px",
        color: "#2e6417",
        borderBottom: "4px solid #2e6417",
        display: "inline-block",
        paddingBottom: "6px",
        marginBottom: "30px"
      }}>
        About Biblioteca
      </h2>

      {/* Tanıtım */}
      <p style={{ fontSize: "18px", marginBottom: "20px" }}>
        <strong style={{ color: "#2e6417" }}>Biblioteca</strong> is more than just a digital library – 
        it’s your personal reading companion.
        the platform combines a modern design with powerful features to help you 
        <em> organize, explore, and reflect </em> on your reading journey.
      </p>

      {/* Özellikler Listesi */}
      <ul style={{ fontSize: "17px", marginLeft: "20px", marginBottom: "25px" }}>
        <li>🔍 <strong>Smart Search:</strong> Find books instantly by title, author, or genre</li>
        <li>📖 <strong>Library Management:</strong> Add, edit, and delete books with ease</li>
        <li>🖼️ <strong>Visual Experience:</strong> Upload custom book covers to personalize your collection</li>
        <li>⭐ <strong>Journaling:</strong> Rate your books, save favorite quotes, and write personal notes</li>
        <li>⚡ <strong>Technology:</strong> Built with a modern stack for speed, reliability, and scalability</li>
      </ul>

      {/* Kullanım Amaçları */}
      <h3 style={{ fontSize: "24px", color: "#2e6417", marginBottom: "15px" }}>
        Why use Biblioteca?
      </h3>
      <p style={{ fontSize: "17px", marginBottom: "20px" }}>
        Whether you are a <strong>casual reader</strong> who wants to track finished books,  
        or a <strong>book lover</strong> building a lifelong collection, Biblioteca provides the 
        tools you need to stay organized. With note-taking and journaling features,  
        it also serves as a digital diary of your literary journey.  
      </p>

      <p style={{ fontSize: "17px", fontStyle: "italic", color: "#555" }}>
        Biblioteca is not just about storing titles – it’s about creating a space where 
        <span style={{ color: "#2e6417", fontWeight: "bold" }}> your reading memories live</span>.  
        Accessible anytime, anywhere. 🌍
      </p>
    </div>
  );
}

export default About;
