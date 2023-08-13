let txtBox = document.getElementById('txtInput');
let myBtn = document.getElementById('btn');

let hiddenVal = Math.floor(Math.random() * 101);

myBtn.onclick = guessMe;
// txtbox.addeventlistener("keyup", function(event) {
//   if (event.keycode === 13) {
//     event.preventdefault();
//     document.getelementbyid('btn').click();
//   }
// })
let count = 0;

function guessMe() {
  let val = parseInt(txtBox.value);

  if (isNaN(val)) {
    alert("Please enter a number in correct format!");
    txtBox.value="";
  } else if (val > hiddenVal) {
    alert("Guess lower!");
    txtBox.value="";
    count++;
  } else if (val < hiddenVal) {
    alert("Guess higher!");
    txtBox.value="";
    count++;
  } else {
    count++;
    alert("Congratulations! You predicted in "+count+" guess(es)!");
    count = 0;
    let hiddenVal = Math.floor(Math.random() * 101);
    txtBox.value="";
  }
}
