﻿using System;
using System.ServiceModel;
namespace MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question ...");
        }

        public string ObtainAnswerToQuestion(string userQestion)
        {
            string[] answers = { "Future Uncertain", "Yes", "No","Hazy","Ask again later","Definitely"};
            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }
    }
}
