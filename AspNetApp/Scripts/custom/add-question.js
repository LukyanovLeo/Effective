$(document).ready(function () {
	var questionBlock = $('#questions');
	$('#btnAddQuestion').click(function (e) {
		e.preventDefault();
		$('<label>Номер вопроса</label>').appendTo(questionBlock);
		$('<input type="number" name="number" class="form-control"/><br/>').appendTo(questionBlock);
		$('<label>Текст вопроса</label>').appendTo(questionBlock);
		$('<input type="text" name="text" class="form-control"/><br/>').appendTo(questionBlock);
		$('<label>Тип вопроса</label>').appendTo(questionBlock);
		$('<select class="sel1">' +
			'<option value="single">Вопрос с единственным ответом</option>' +
			'<option value="multiple">Вопрос с множественными ответами</option>' +
			'<option value="input">Вопрос с вводом ответа</option>' +
			'<option value="free">Вопрос с произвольным ответом</option>' +
			'</select>').appendTo(questionBlock);
		$('<div class="unique"></div>').appendTo(questionBlock);
	});
});