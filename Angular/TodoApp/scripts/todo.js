var model = {
	"user" : "Keni"//,
//	"tasks" : [{"description": "Play Video Games", completed: false}
//	,{"description": "Go for a Walk", completed: true}
//	,{"description": "Played Basketball", completed: false}
//	,{"description": "Taught Angular", completed: true}]
}

var toDoApp = angular.module("ToDoList", []);

toDoApp.filter("finishedTasks", function(){
		return function (tasks, showComplete) {
		
		var result = [];
		
		angular.forEach(tasks, function (task){
			if(task.completed == false || showComplete == true)
			    result.push(task);
		});
		
		return result;
	}
});
	

toDoApp.run(function ($http){
	$http.get("/json/todo.json").success(function (data){
	   model.tasks = data;	
	});
});

toDoApp.controller("ToDoCtrl", function ($scope){
	
	$scope.todo = model;
	
    $scope.incompleteCount = function () {
		var count = 0;
		angular.forEach($scope.todo.tasks, function (task) {
			if(!task.completed)
			   count++;
		});
		return count;
	};
	
	
	$scope.warningLevel = function (){
		return $scope.incompleteCount() < 3 ? "label-success" : "label-danger";
	};
	
	$scope.addNewItem = function (taskText) {
	
	$scope.todo.tasks.push({"description": taskText, "completed" : false});
		
	};

});