function solve() {
  let anchors = document.getElementsByTagName("a");
  let spans = document.getElementsByTagName("span");

  for (let i = 0; i < anchors.length; i++) {
    anchors[i].addEventListener("click", function() {
      let text = spans[i].innerHTML;
      let numberOfVisits = Number(text.split(" ")[1]);
      numberOfVisits++;
      spans[i].innerHTML = `Visited: ${numberOfVisits} times`;
    });
  }
}