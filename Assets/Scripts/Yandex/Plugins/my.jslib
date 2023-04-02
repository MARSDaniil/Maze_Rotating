mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
    console.log("Hello world");
  },


 RateGame: function () {
   ysdk.feedback.canReview()
        .then(({ value, reason }) => {
            if (value) {
                ysdk.feedback.requestReview()
                    .then(({ feedbackSent }) => {
                        console.log(feedbackSent);
                    })
            } else {
                console.log(reason)
            }
        })
  },


SaveExtern: function (date) {
   var dataString = UTF8ToString(date);
   var myobj = JSON.parse(dataString);
   player.setData(myobj);
  },

LoadExtern: function () {
   player.getData().then(_date => {
    const myJSON = JSON.stringify(_date);
    myGameInstance.SendMessege('Progress','SetPlayerInfo',myJSON);
   })

  },


});