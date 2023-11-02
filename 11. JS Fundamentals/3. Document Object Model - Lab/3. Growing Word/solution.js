function solve() {
   document.getElementsByTagName("button")[0].addEventListener('click', function() { 

      let p = document.getElementsByTagName("p")[document.getElementsByTagName("p").length - 1];
      let counter = p.getAttribute("counter");
      let colors = ["blue", "green", "red"];

      if (!counter) {
         counter = 1;
      }
      else {
         counter++;
      }

      p.style.color = colors[(counter - 1) % colors.length];
      p.style.fontSize = 2 * counter + "px";
      p.setAttribute("counter", counter);
   }, false);
}