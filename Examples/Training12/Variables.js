let num = 2;
num

let num1 = 2, num2 = 3, num3 = 4;
num1
num2
num3

let text = "some string";
text

text + num1

num2 + num3

num1.toString()

parseInt(text)

parseInt("5")

var numbers = [num1, num2, num3];
numbers

numbers[0]
numbers[0] = 20
numbers[0]
num1

var square = function(num) { return num * num; }
square
square(2)

var person = { FirstName:"Joe", LastName:"Mackie" }
person
person.FirstName = "Bob"
person
person.LastName

//shift+enter for multiple lines
let globalnum = 5;
function ReturnGlobal() {
  return globalnum;
}
ReturnGlobal()
globalnum

function ReturnLocal() {
  let localnum = 7;
  return localnum;
}
ReturnLocal
localnum

function ReturnLocal() {
  let localnum2;
  if(1==1) {
    localnum2 = 7;
  }
  return localnum2;
}
ReturnLocal()

function ReturnLocal() {
  if(1==1) {
    let localnum2 = 7;
  }
  return localnum2;
}
ReturnLocal()