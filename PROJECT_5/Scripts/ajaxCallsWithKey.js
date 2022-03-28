function ajaxCall2(method, api, data, successCB, errorCB) {
    $.ajax({
        type: method,
        url: api,
        data: data,
        cache: false,
        headers: {
            'x-rapidapi-key': 'dca2725b5fmshf966fb6d48053f4p186f83jsn8182a1d0d0ce',   // replace it with your own key
        },
        contentType: "application/json",
        dataType: "json",
        success: successCB,
        error: errorCB
    });
}