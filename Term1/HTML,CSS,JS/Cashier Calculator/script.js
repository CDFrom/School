// Create variables for buttons
let addProduct = document.getElementById('addProduct');
let addPrice = document.getElementById('addPrice');
let newTransaction = document.getElementById('newTransaction');
let addToCart = document.getElementById('addToCart');
let pay = document.getElementById('pay');

// Call functions on click
addProduct.onclick = productAdd;
addPrice.onclick = priceAdd;
newTransaction.onclick = clear;
addToCart.onclick = cartAdd;
pay.onclick = payCart;

// Create object array
let products = []

// Numpad function
let cells = document.getElementsByClassName('cell');
for (let cell of cells) {
  cell.onclick = addNum;
}

// Create functions
// Add product to dropdown menu only if it isn't already there, checks casing
function productAdd() {
  let flag = false;
  let str = document.getElementById('product').value;
  let option = document.createElement('option');
  for (let i = 0; i < document.getElementById('productDropDown').length; i++) {
    txt = document.getElementById('productDropDown')[i].value.toLowerCase();
    if (txt.includes(str.toLowerCase())) {
      flag = true;
      break;
    }
  }
  if (!flag) {
    let item = {
      product: str
    }
    products.push(item);
    option.text = str;
    document.getElementById('productDropDown').add(option);
    document.getElementById('productDropDown').selectedIndex = document.getElementById('productDropDown').length - 1;
  } else {
    alert("Item already on list.")
  }
  document.getElementById('product').value = "";
}

// Add a price to the product and add it to a checkout dropdown menu, if item is already there update the price
function priceAdd() {
  let i = 0;
  let flag = false;
  let num = document.getElementById('productDropDown').selectedIndex - 1;
  let item = document.getElementById('productDropDown')[num + 1].value;
  let itemPrice = parseFloat(document.getElementById('price').value);
  products[num].price = itemPrice;
  let str = products[num].product + " $" + products[num].price + "/unit";
  for (i; i < document.getElementById('checkoutDropDown').length; i++) {
    txt = document.getElementById('checkoutDropDown')[i].value
    if (txt.includes(item)) {
      flag = true;
      break;
    }
  }
  if (!flag) {
    let option = document.createElement('option');
    option.text = str;
    document.getElementById('checkoutDropDown').add(option);
    document.getElementById('checkoutDropDown').selectedIndex = i;
  } else {
    document.getElementById('checkoutDropDown').selectedIndex = i;
    document.getElementById('checkoutDropDown')[i].innerHTML = str;
  }
  document.getElementById('price').value = "";
}

// Clear everything but leave options available, used for paying and starting new transaction
function clear() {
  document.getElementById('productDropDown').selectedIndex = 0;
  document.getElementById('checkoutDropDown').selectedIndex = 0;
  document.getElementById('numToAdd').value = "";
  document.getElementById('product').value = "";
  document.getElementById('price').value = "";
  let n = document.getElementById('receipt').tBodies[0].rows.length;
  for (let i = n - 1; i >= 0; i--) {
    document.getElementById('receipt').tBodies[0].deleteRow(i);
  }
  document.getElementById('totalPrice').innerHTML = "0.00";
  document.getElementById('tax').innerHTML = "0.00";
  document.getElementById('due').innerHTML = "0.00";
}

// Add item to cart/receipt list
// If item is already there AND price has not been changed, will update the amount
// If price has changed will add a new row
function cartAdd() {
  let flag = false;
  let n = 0;
  let str = document.getElementById('checkoutDropDown').value;
  let itemName = str.substring(0, str.indexOf('$')).trim();
  let unitPrice = parseFloat(str.substring((str.indexOf('$') + 1), str.indexOf('/')));
  //Update this
  let unitAmount = parseInt(document.getElementById('numToAdd').value);
  let productPrice = parseFloat(unitPrice) * unitAmount;

  for (n; n < document.getElementById('receipt').tBodies[0].rows.length; n++) {
    s = document.getElementById('receipt').tBodies[0].rows[n].cells[0].innerHTML;
    c = document.getElementById('receipt').tBodies[0].rows[n].cells[1].innerHTML;
    if (s == itemName && c == unitPrice) {
      flag = true;
      break;
    }
  }
  if (flag) {
    let newNumber = parseInt(document.getElementById('receipt').tBodies[0].rows[n].cells[2].innerHTML);
    newNumber += unitAmount;
    document.getElementById('receipt').tBodies[0].rows[n].cells[2].innerHTML = newNumber;
    let newCost = parseFloat(document.getElementById('receipt').tBodies[0].rows[n].cells[3].innerHTML);
    newCost += productPrice;
    document.getElementById('receipt').tBodies[0].rows[n].cells[3].innerHTML = newCost.toFixed(2);
  } else {
    let row = document.getElementById('receipt').tBodies[0].insertRow();
    let cell1 = row.insertCell();
    let cell2 = row.insertCell();
    let cell3 = row.insertCell();
    let cell4 = row.insertCell();
    cell1.innerHTML = itemName;
    cell2.innerHTML = unitPrice.toFixed(2);
    cell3.innerHTML = unitAmount;
    cell4.innerHTML = productPrice.toFixed(2);
  }

  let total = 0;
  for (var i = 0; i < document.getElementById('receipt').tBodies[0].rows.length; i++) {
    total += parseFloat(document.getElementById('receipt').tBodies[0].rows[i].cells[3].innerHTML)
  }
  let tax = total * 0.05;
  let due = total + tax;
  document.getElementById('totalPrice').innerHTML = total.toFixed(2);
  document.getElementById('tax').innerHTML = tax.toFixed(2);
  document.getElementById('due').innerHTML = due.toFixed(2);
  document.getElementById('numToAdd').value = "";
}

// Pay for everything and empty the car resetting values
function payCart() {
  alert("Thank you for shopping!\nPlease come again!");
  clear();
}

// Add a number to the units section
function addNum() {
  document.getElementById('numToAdd').value += this.name;
}

// Get date info
time12Hour();

function time12Hour() {
  let d = new Date();
  let months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
  let hours = d.getHours();
  let time = 'am';
  if (hours > 12) time = 'pm'
  hours %= 12;
  if (hours == 0) hours = 12;
  let minutes = d.getMinutes();
  if (minutes < 10) minutes = '0' + minutes;
  let str = hours + ':' + minutes + ' ' + time;
  // Set date and time
  document.getElementById('time').textContent = str;
  document.getElementById('date').textContent = months[d.getMonth()] + " " + d.getDate() + ", " + d.getFullYear();
  setTimeout(time12Hour, 1000)
}
