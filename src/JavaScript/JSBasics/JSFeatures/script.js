const alphabet = ['a', 'b', 'c', 'd', 'e', 'f']
const numbers = ['1', '2', '3', '4', '5', '6']


// const a = alphabet[0];
// const b = alphabet[1];
// const c = alphabet[3]
const [a, b,,c, ...rest] = alphabet;
console.log(a);
console.log(b);
console.log(c);
console.log(rest);

const newArray = [...alphabet, ...numbers];
console.log(newArray);

function sumAndMultiply(a, b) {
    return [a+b, a*b];
}

const [sum, multiply, division = "no result"] = sumAndMultiply(2, 3);
console.log(sum);
console.log(multiply);
console.log(division)


const studentOne = {
    name: 'Josh',
    age: 19,
    address: {
        city: 'FieldTown',
        state: 'New York'
    }
}

const studentTwo = {
    name: 'Sam',
    age: 21,
    address: {
        city: 'Joinville',
        state: 'New York'
    }
}

// const studentTwo = {
//     name: 'Sam',
//     degree: 'computer science'
// }
// second object overrides information in other object
// const personThree = {...studentOne, ...studentTwo};

const { name: firstName, age, lowestGrade = 'N/A', address: { city } } = studentTwo;
console.log(firstName);
console.log(age);
console.log(city)


function printStudent({ name, age, hobby = "there is nothing to show" }) {
    console.log(`Name is: ${name}. Age is ${age}. Hobby is: ${hobby}`);
}
printStudent(studentTwo);
