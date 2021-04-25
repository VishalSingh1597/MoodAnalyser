using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;

namespace MSTestMoodAnalyser
{
    ///* TC 7.1:- Given happy Should Return Happy
    // */

    //[TestMethod]
    //public void GivenHappyMessageWithReflectorShouldReturnHappy()
    //{
    //    var expected = "happy";
    //    string mood = MoodAnalyzerFactory.SetField("HAPPY", "message");
    //    Assert.AreEqual(expected.ToUpper(), mood);
    //}

    /* TC7.1:- Set Happy Message with Reflector Should Return HAPPY.
     *         - To pass this TC, Use Reflector to Set the Field Value and Invoke Method using Reflection 
     *         and Assert HAPPY Mood.
     */
    [TestMethod]
    public void GivenMessageDynamically_returnMessage()
    {
        string expected = "Iam so happy";

        string actual = MoodAnalyzerFactory.SetField("Iam so happy", "message");
        Assert.AreEqual(expected, actual);
    }


    /* TC 7.2:- Set Field When Improper Should Throw Exception with No Such Field.
     *          - To pass this TC, Use Reflector to Set the Value on improper Field, catch the Exception and 
                throw indicating No Such Field error.
     */
    [TestMethod]
    public void GivenImproperFieldName_ThrowNoSuchFieldException()
    {

        string expected = "No Such Field";
        try
        {
            MoodAnalyzerFactory.SetField("Iam so happy", "wrongMessage");
        }
        catch (MoodAnalyzerException e)
        {
            Assert.AreEqual(expected, e.Message);
        }

    }
    /* TC 7.3:- Setting Null Message with Reflector Should Throw Exception.
                - To pass this TC, Use Reflector to Set the Field Value to null and check Exception.
    */

    [TestMethod]
    public void GivenNullMessage_ThrowException()
    {
        string expected = "Mood should not be NULL";

        try
        {
            MoodAnalyzerFactory.SetField(null, "message");
        }
        catch (MoodAnalyzerException e)
        {
            Assert.AreEqual(expected, e.Message);
        }

    }

}
}
