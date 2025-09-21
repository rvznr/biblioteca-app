import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Navbar from "./components/Navbar";
import Home from "./pages/Home";
import About from "./pages/About";
import Library from "./pages/Library";  
import BookDetail from "./pages/BookDetail";
import Footer  from "./components/Footer";

function App() {
  return (
    <Router>
      <Navbar />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/library" element={<Library />} />  
        <Route path="/about" element={<About />} />
         <Route path="/books/:id" element={<BookDetail />} />
      </Routes>
       <Footer /> 
    </Router>
  );
}

export default App;
