using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;



namespace MSTestMoodAnalyser
/* TC 3.1:- NULL Given NULL Mood Should Throw MoodAnalysisException
                    To pass this Test Case in try catch block throw MoodAnalysisException
         */
        [TestMethod]
public void Given_Nullmood_Using_CustomExpection_Return_Null()  //Method
{
    MoodAnalyzer mood = new MoodAnalyzer(null); //Create object and arrange 
                                                //string actual = "";
    string actual = "";

    try
    {
        actual = mood.Analyzer();    //act

    }
    catch (MoodAnalyzerException exception)
    {
        Assert.AreEqual("Mood should not be null", exception.Message);  //Assert
    }
}

/* TC 3.2:- Empty Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood 
           - Handle Empty Mood Scenario throw MoodAnalysisException and inform user of the EmptyMood
           HINT: Use Enum to EMPTY or NULL
*/
[TestMethod]
public void Given_Emptymood_Using_CustomExpection_Return_Empty()  //Method
{

    string actual = "";

    try
    {
        string message = string.Empty;
        MoodAnalyzer mood = new MoodAnalyzer(message); //Create object and arrange 
        actual = mood.Analyzer();    //act

    }
    catch (MoodAnalyzerException exception)
    {
        Assert.AreEqual("Mood should not be empty", exception.Message);  //Assert
    }

}
}
}