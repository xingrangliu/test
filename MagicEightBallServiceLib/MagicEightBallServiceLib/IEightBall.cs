using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace MagicEightBallServiceLib
{
    [ServiceContract]
    interface IEightBall
    {
        //Ask a question, receive an anwser !
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }

}
