let p = new Promise((resolve, reject) => {
    let name = 'dominic martinez'

    if (name == 'dominic martinez') {
        resolve('Success!!!!')
    } else {
        reject('Failed')
    }
})


p.then((message) => {
    console.log(`This is in the then ${message}`);
    
}).catch((message) => {
    console.log(`Thi is in the the catch ${message} failure!`);
    
})


const loadRenderer = new Promise((resolve, reject) => {
    resolve('Renderer has been loaded successfully.')
})

const loadInputManager = new Promise((resolve, reject) => {
    resolve('Input manager has been loaded successfully.')
})

const loadImages = new Promise((resolve, reject) => {
    let hasConnection = true

    if (hasConnection) {
        resolve('Images has been loaded successfully.')
    } else {
        reject('Images could be loaded due to no connection to main server.')
    }
})

Promise.all([
    loadRenderer,
    loadInputManager,
    loadImages
]).then((messages) => {
    console.log(messages)
}).catch((messages) => {
    console.log(messages)
})

Promise.race([
    loadRenderer,
    loadInputManager,
    loadInputManager
]).then((messages) => {
    console.log(messages)
}).catch((messages) => {
    console.log(messages)
})