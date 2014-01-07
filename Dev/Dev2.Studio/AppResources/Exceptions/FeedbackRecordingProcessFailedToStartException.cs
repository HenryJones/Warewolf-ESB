﻿using System;

//2013.02.06: Ashley Lewis - Bug 8611
// ReSharper disable once CheckNamespace
namespace Dev2.Studio.AppResources.Exceptions
{
    public class FeedbackRecordingProcessFailedToStartException : Exception
    {
        public FeedbackRecordingProcessFailedToStartException()
        {

        }

        public FeedbackRecordingProcessFailedToStartException(string message)
            : base(message)
        {

        }
    }
}
