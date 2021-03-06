$(onReady);

function onReady(){
  $('#clear').on('click', clearClick);
  $('.input-button').on('click', inputClick);
  $('#equals').on('click', equalsClick);
  $('.operator').on('click', operatorClick);
  $('#clear-history').on('click', clearHistoryClick);
  $('#history').on('click','.history', singleClick);
  getMath();
}

// Append Function
function appendHistory(list){
  let el = $('#history');
  el.empty();
  for(let i = 0 ; i < list.length; i++){
    el.append(`
        <li class="history" data-index=${i}>${list[i].equation} = ${list[i].answer}</li>
    `)
  }
}

// Button Functions
// Clears the input field
function clearClick(){
  $('#math-visual').val('')
  $('.operator').attr('disabled',false);
  $('#output').text('0')
}

// Clears the history
function clearHistoryClick(){
  if(confirm('Are you sure you want to clear your history?')){
    deleteHistory();
  }
}

// Adds button value to input field
function inputClick(){
  let el = $('#math-visual')
  el.val(el.val()+$(this).text());
}

// Will do the math part in the future
function equalsClick(){
  let el = $('#math-visual')
  if(Number(el.val().charAt(el.val().length-1))){
    postMath(getValues());
    $('.operator').attr('disabled',false);
    el.val('')
  } else {
    alert('Please use two numbers.');
  }
};

// Reruns a single line from history
function singleClick(){
  let equalPosition = $(this).text().indexOf('=');
  let formula = $(this).text().slice(0,equalPosition-1);
  $('#math-visual').val(formula);
  equalsClick();
}

// Will deactivate the buttons when an operator is clicked
function operatorClick(){
  $('.operator').attr('disabled',true);
}

// Gets the input and returns it
function getValues(){
  let input = {
    input: $('#math-visual').val()
  };
  return input;
}

// AJAX functions
// Gets history from server
function getMath(){
  $.ajax({
    type: 'GET',
    url: '/MathHistories'
  }).then(function(response){
    appendHistory(response);
  }).catch(function(err){
    alert('Error with get math');
    console.log(err);
  })
}

// Posts the euation to the server
function postMath(payload){
  console.log('in post');
  console.log(payload);
  $.ajax({
    type: 'POST',
    contentType: "application/json",
    url: '/MathHistories',
    data: JSON.stringify({Equation: payload.input})
  }).then(function(response){
    $('#output').text(response.answer);
    getMath();
  }).catch(function(err){
    alert('Error with post math');
    console.log(err);
  })
}

function deleteHistory(){
  $.ajax({
    type: 'DELETE',
    url: '/MathHistories'
  }).then(function(response){
    getMath();
  }).catch(function(err){
    alert('Error with delete math');
    console.log(err);
  })
}