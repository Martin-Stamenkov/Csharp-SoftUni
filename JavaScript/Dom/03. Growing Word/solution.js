function growingWord() {

  let paragraph = document.querySelectorAll("p")[2];

  if (paragraph.style.color === "" && paragraph.style.fontSize === "") {
    paragraph.style.color = "blue"
    paragraph.style.fontSize = "2px"
    return;
  } else if (paragraph.style.color === "blue") {
    paragraph.style.color = "green";
  } else if (paragraph.style.color === "green") {
    paragraph.style.color = "red";
  } else if (paragraph.style.color === "red") {
    paragraph.style.color = "blue";
  };

 paragraph.style.fontSize = parseInt(paragraph.style.fontSize) * 2 + 'px';
}