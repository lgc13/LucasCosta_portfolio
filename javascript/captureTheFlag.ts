console.log("This is my capture the flag challenge")

/**
 * Looking for the following:
 *
 * <code data-class="23*">
 *   <div data-tag="*93">
 *     <span data-id="*21*">
 *       <i class="char" value="VALID_CHARACTER"></i>
 *     </span>
 *   </div>
 * </code>
 */

const test = document.getElementsByTagName('h1')[0]
console.log("test: ", test.innerHTML)

let mysteryUrl = ''

document.querySelectorAll("code[data-class^='23']").forEach(codeDataClasses23 => {
    const divTags = codeDataClasses23.querySelectorAll("div[data-tag$='93']")

    divTags.forEach(divTag => {
        const spanDataIds = divTag.querySelectorAll("span[data-id*='21']")

        spanDataIds.forEach(spanDataId => {
            const iElementValue = spanDataId.querySelector("i").attributes['value'].value

            mysteryUrl += iElementValue
        })
    })
})

console.log({mysteryUrl})

/*
    code sandbox for part 2:
    https://codesandbox.io/p/sandbox/bold-rain-fk639r?file=%2Fsrc%2FApp.tsx%3A6%2C125
 */

