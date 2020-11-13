
// arrow function
getSpecialitiesByCourseId = courseId => {
    debugger;
    $.ajax({
        type: "post",
        data: { courseId: $('#courses-dd').val() },
        url: "/Program_Study/GetSpecialitiesByCourseId",
        success: function (response) {
            if (response.isSuccess) {
                var html = "";
                for (let item = 0; item < response.data.length; item++) {
                    html += `<option value='${response.data[item].value}'>${response.data[item].text}</option>`;
                }
                $('#specialities-dd').html(html);
            }
        },
        error: function () { }
    });
}