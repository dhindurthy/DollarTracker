﻿app.factory("expenseStory", ['$http', 'dolt', function ($http, dolt) {

    var expenseStory = {};
    expenseStory.Add = function (story) {
        var url = dolt.getApiUrl('addExpenseStory');
        return $http.post(url, story);
    }

    expenseStory.getAllExpenses = function (expenseStoryId) {
        var url = dolt.getApiUrl('expense') + '/' +expenseStoryId;
        console.log(url);
        return $http.get(url);
    }

    expenseStory.deleteExpenseStory = function (expenseStoryId) {
        var url = dolt.getApiUrl('deleteExpenseStory') + '/' + expenseStoryId;
        console.log('delete url:' + url);
        return $http.delete(url);
    }

    return expenseStory;

}]);