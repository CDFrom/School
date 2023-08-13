let gName = "";
let allGuests=[];

while((gName=prompt("Please enter a guest name: "))!="0")
{
  allGuests.push(gName);
}

alert("Total number of guests are: "+allGuests.length+"\nThe names of the guests are: "+allGuests.join(", "))
