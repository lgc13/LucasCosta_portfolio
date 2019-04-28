let todos = [
  {id: 1, text: "Take out trash and recycling", complete: true},
  {id: 2, text: "Pick up dry cleaning", complete: false},
  {id: 3, text: "Get oil change", complete: false},
  {id: 4, text: "Write thank-you notes", complete: false},
];
let itemsComplete = todos.filter((todo) => todo.complete === true).length;
const mainTodoList = document.getElementById('main-todo-list');
const todoDiv = document.getElementsByClassName('todo')[0];
let isHiding = false;

const displayInitialPage = () => {
  document.getElementsByTagName('input')[1].id = 'inputBox';
  document.getElementById('inputBox')
    .addEventListener("keyup", saveNewItem);

  document.getElementsByClassName('todo')[0].remove(); // delete current

  todos.forEach((todo) => {
    const newTodoDiv = todoDiv.cloneNode(true);
    setNewDivAttributes(newTodoDiv, todo);
    styleTodoItem(todo, newTodoDiv);
    mainTodoList.appendChild(newTodoDiv);
    if (todo.complete === true) {
      itemsComplete =+ 1;
    }
  });
}

const createHideOrShowButton = () => {
  const divElem = document.createElement('div');
  divElem.id = 'hide-show-div';
  const buttonElem = document.createElement('button');
  buttonElem.id = 'hide-show-button';
  buttonElem.innerHTML = 'Hide completed items';
  buttonElem.addEventListener('click', hideOrShowTodos);

  divElem.appendChild(buttonElem);
  document.getElementById('remaining-count').parentElement.appendChild(divElem);
}

const hideOrShowTodos = () => {
  if (!isHiding) {
    todos.filter(todo => todo.complete === true).forEach(todo => {
      document.getElementById(todo.id).parentElement.classList.add('hidden');
      document.getElementById('hide-show-button').innerHTML = 'Show completed items';
    });
    isHiding = true;
  } else {
    todos.filter(todo => todo.complete === true).forEach(todo => {
      document.getElementById(todo.id).parentElement.classList.remove('hidden');
      document.getElementById('hide-show-button').innerHTML = 'Hide completed items';
    });
    isHiding = false;
  }
}

const styleTodoItem = (todoItem, divTodo) => {

  if (todoItem.complete) {
    divTodo.classList.add('complete');
    divTodo.getElementsByTagName('input')[0].checked = true;
  } else {
    divTodo.classList.remove('complete');
    divTodo.getElementsByTagName('input')[0].checked = false;
  }
}

const checkBoxPress = (spanElem) => {
  // get todoId of item clicked on
  const todoId = Number(spanElem.parentElement
    .getElementsByClassName('todo-text')[0].id);

  // find item with that id
  const todoItem = todos.find(todo => todo.id === todoId);

  if (todoItem.complete) {
    todoItem.complete = false;
    itemsComplete -= 1;
  } else {
    todoItem.complete = true;
    itemsComplete += 1;
  }

  styleTodoItem(todoItem, spanElem.parentElement);

  changeItemsRemain();

  // todos.filter((todo) => todo.complete == true )
  //   .forEach((todo) => {console.log('true:' , todo.text)});
  // console.log('------');
}

const changeItemsRemain = () => {
  document.getElementById('remaining-count')
    .innerHTML = todos.length - itemsComplete;
}

const saveNewItem = (event) => {
  console.log('in saveNewItem');
  const inputTextElem = document.getElementById('inputBox');
  if (event.keyCode === 13 && inputTextElem.value.trim()) {
    const newItem = {
      id: todos[todos.length - 1].id + 1,
      text: inputTextElem.value.trim(),
      complete: false
    };
    todos.push(newItem);
    changeItemsRemain();
    const newTodoDiv = todoDiv.cloneNode(true);
    setNewDivAttributes(newTodoDiv, newItem);

    mainTodoList.appendChild(newTodoDiv);
    inputTextElem.value = '';
  }
}

const setNewDivAttributes = (newTodoDiv, todo) => {
  newTodoDiv.getElementsByTagName('span')[0].id = todo.id;
  newTodoDiv.getElementsByTagName('span')[0].innerHTML = todo.text;

  newTodoDiv.addEventListener("click", () => checkBoxPress(newTodoDiv
    .getElementsByTagName('span')[0]));
}

displayInitialPage();
createHideOrShowButton();
changeItemsRemain();
