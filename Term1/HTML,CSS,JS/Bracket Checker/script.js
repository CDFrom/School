let input = "";
let stack = [];

input = prompt("Please enter an appropriate string of brackets: ");

let index=0;
for (let i of input) {
  if (i == '(') {
    stack.push(i);
  } else if (i == ')' && stack.length != 0) {
    stack.pop();
  } else if (i == ')' && stack.length == 0) {
    alert("Invalid");
    break;
  }
  if (index == (input.length - 1) && stack.length == 0) {
    alert("Valid");
  }
  if (index == (input.length - 1) && stack.length != 0) {
    alert("Invalid");
  }
  index++;
}
