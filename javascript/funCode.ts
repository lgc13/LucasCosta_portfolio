/**
 * Running with:
 *
 * yarn global add typescript
 * tsc funCode.ts && node funCode.js
 */
let items: { id: number, isComplete: boolean }[] = []

const lastId = items[items.length - 1]?.id
const newId = lastId ? lastId + 1 : 1

console.log({ newId })

const items2 = [{ id: 6 }]

const lastId2 = items2[items2.length - 1]?.id
const newId2 = lastId2 ? lastId2 + 1 : 1

console.log({ newId2 })


// Updating
items = [{ id: 1, isComplete: false} , { id: 2, isComplete: false}]

console.log("Before update: ", { items })
const request = { id : 2, isComplete: true}

const newItems = items.map(it => {
    if (it.id !== request.id) return it

    return {
        ...it,
        isComplete: request.isComplete
    }
})

items = newItems
console.log("After update: ", { items })
