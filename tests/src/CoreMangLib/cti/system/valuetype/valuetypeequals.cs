using System;
using System.Globalization;
using TestLibrary;


public class A{}

public struct S 
{
    public A obj;
}

public struct SGen<T> { }

public struct Структура { }

public struct AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAELK { }

public struct AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAELM { }


class ValueTypeEquals
{
    static int Main()
    {
        ValueTypeEquals test = new ValueTypeEquals();

        TestFramework.BeginTestCase("ValueType.Equals(Object)");

        if (test.RunTests())
        {
            TestFramework.EndTestCase();
            TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestFramework.EndTestCase();
            TestFramework.LogInformation("FAIL");
            return 0;
        }

    }

    public bool RunTests()
    {
        bool retVal = true;


        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;
        retVal = PosTest5() && retVal;
        retVal = PosTest6() && retVal;
        retVal = PosTest7() && retVal;
        retVal = PosTest8() && retVal;

        return retVal;
    }


    public bool PosTest1()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Comparing two non-generic structs");

        try
        {
            S s1 = new S();
            S s2 = new S();

            if (!s1.Equals(s2))
            {
                TestLibrary.TestFramework.LogError("001", "s1.Equals(s2) should have returned true!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
        }

        return retVal;
    }


    public bool PosTest2()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest2: Comparing generic struct with non-generic struct");

        try
        {
            S s1 = new S();
            SGen<string> s2;

            if (s1.Equals(s2))
            {
                TestLibrary.TestFramework.LogError("003", "s1.Equals(s2) should have returned false!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
        }

        return retVal;
    }


    public bool PosTest3()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest3: Comparing two generic structs");

        try
        {
            SGen<int> s1;
            SGen<int> s2;

            if (!s1.Equals(s2))
            {
                TestLibrary.TestFramework.LogError("005", "s1.Equals(s2) should have returned true!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
        }

        return retVal;
    }

    public bool PosTest4()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest4: Comparing two unicode name structs");

        try
        {
            Структура s1;
            Структура s2;

            if (!s1.Equals(s2))
            {
                TestLibrary.TestFramework.LogError("007", "s1.Equals(s2) should have returned true!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("008", "Unexpected exception: " + e);
        }

        return retVal;
    }

    public bool PosTest5()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest5: Comparing unicode name struct with non-generic struct");

        try
        {
            Структура s1;
            S s2 = new S();

            if (s1.Equals(s2))
            {
                TestLibrary.TestFramework.LogError("009", "s1.Equals(s2) should have returned false!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("010", "Unexpected exception: " + e);
        }

        return retVal;
    }
    
    public bool PosTest6()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest6: Comparing two structs with very large same names");

        try
        {
            AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAELK s1;
            AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAELK s2;

            if (!s1.Equals(s2))
            {
                TestLibrary.TestFramework.LogError("011", "s1.Equals(s2) should have returned true!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("012", "Unexpected exception: " + e);
        }

        return retVal;
    }

    public bool PosTest7()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest7: Comparing two structs with very large different names");

        try
        {
            AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAELK s1;
            AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAELM s2;

            if (s1.Equals(s2))
            {
                TestLibrary.TestFramework.LogError("013", "s1.Equals(s2) should have returned false!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("014", "Unexpected exception: " + e);
        }

        return retVal;
    }

      public bool PosTest8()
    {
        bool retVal = false;

        TestLibrary.TestFramework.BeginScenario("PosTest8: object passed to Equals is null");

        try
        {
            S s1 = new S();

            if (s1.Equals(null))
            {
                TestLibrary.TestFramework.LogError("015", "s1.Equals(null) should have returned false!");
            }
            else
            {
                retVal = true;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("016", "Unexpected exception: " + e);
        }

        return retVal;
    }
}