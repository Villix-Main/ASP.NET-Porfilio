export class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    
    SayHello() {
        console.log(`Hello I'm ${this.name}`);
    }
}