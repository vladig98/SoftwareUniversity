function solve() {
   var profile1button = document.getElementsByTagName("button")[0];
   var profile2button = document.getElementsByTagName("button")[1];
   var profile3button = document.getElementsByTagName("button")[2];

   var divDetails1 = document.getElementById("user1HiddenFields");
   var divDetails2 = document.getElementById("user2HiddenFields");
   var divDetails3 = document.getElementById("user3HiddenFields");

   var profile1inputs = document.getElementsByName("user1Locked");
   var profile2inputs = document.getElementsByName("user2Locked");
   var profile3inputs = document.getElementsByName("user3Locked");

   profile1button.addEventListener("click", function() {
      var checked = [...profile1inputs].filter(function(x) {
         return x.checked;
      })[0];

      if (checked.value == "unlock") {
         divDetails1.style.display = "block";
      }
   });

   profile2button.addEventListener("click", function() {
      var checked = [...profile2inputs].filter(function(x) {
         return x.checked;
      })[0];

      if (checked.value == "unlock") {
         divDetails2.style.display = "block";
      }
   });

   profile3button.addEventListener("click", function() {
      var checked = [...profile3inputs].filter(function(x) {
         return x.checked;
      })[0];

      if (checked.value == "unlock") {
         divDetails3.style.display = "block";
      }
   });
} 