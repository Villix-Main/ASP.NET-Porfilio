let name = "Dominic";
let age = 14;
let isAlive = true;
const SayHello = function(name) {
    console.log(`Hello I'm ${name}!`);
}

let person = CreatePerson("Dominic", 14, 0);
let person1 = CreatePerson("Jack", 15, 24215);
let car = new Car("mustang", "ford", 2015);

person.SayHello();
car.Drive();

function CreatePerson(name, age, salary) {
    let newPerson = {
        name,
        age,
        salary,
        SayHello() {
            console.log(`Hello I'm ${name}`);
        }
    }
    
    return newPerson;
} 

function Car(model, make, year) {
    console.log(this);
    this.model = model;
    this.make = make;
    this.year = year;
    this.Drive = function() {
        console.log("Driving....");
    }
 }
 