import Person from "./person";

export default class Employee extends Person {
    constructor(name, age, rank, salary) {
        super(name, age);
        this.rank = rank;
        this.salary = salary;    
    }
    
    Work() {
        console.log(`${this.name} is working right now`);
    }
} 