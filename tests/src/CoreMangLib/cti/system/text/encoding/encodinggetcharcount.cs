using System;
using System.Text;
using TestLibrary;

class EncodingGetCharCount
{
    static int Main()
    {
        EncodingGetCharCount test = new EncodingGetCharCount();

        TestFramework.BeginTestCase("Encoding.GetCharCount");

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
        bool ret = true;

        // Positive Tests

        ret &= Test1();
        ret &= Test2();
        ret &= Test3();
        ret &= Test4();
        ret &= Test5();
        ret &= Test6();
        ret &= Test7();
        ret &= Test8();
        ret &= Test9();
        ret &= Test10();

        ret &= Test11();
        ret &= Test12();
        ret &= Test13();
   
        ret &= Test40();

        ret &= Test41();
        ret &= Test42();
        ret &= Test43();
        ret &= Test44();
        ret &= Test45();
        ret &= Test46();
        ret &= Test47();
        ret &= Test48();
        ret &= Test49();
        ret &= Test50();

        ret &= Test51();
        ret &= Test52();
        ret &= Test53();
        ret &= Test54();
        ret &= Test55();
        ret &= Test56();
        ret &= Test57();
        ret &= Test58();
        ret &= Test59();
        ret &= Test60();

        ret &= Test61();
        ret &= Test62();
        ret &= Test63();
        ret &= Test64();
        ret &= Test65();

        // Negative Tests

        ret &= Test76();
        ret &= Test79();
        ret &= Test80();

        ret &= Test81();
        ret &= Test82();
        ret &= Test83();
        ret &= Test84();
        ret &= Test85();
        ret &= Test96();
        ret &= Test97();
        ret &= Test98();
        ret &= Test99();
        ret &= Test100();

        ret &= Test101();
        ret &= Test102();
        ret &= Test103();
        ret &= Test104();
        ret &= Test105();

        return ret;
    }

    // Positive Tests
    public bool Test1() { return PositiveTestString(Encoding.UTF8, 10, new byte[] { 84, 101, 115, 116, 83, 116, 114, 105, 110, 103 }, "00A"); }
    public bool Test2() { return PositiveTestString(Encoding.UTF8, 0, new byte[] { }, "00B"); }
    public bool Test3() { return PositiveTestString(Encoding.UTF8, 7, new byte[] { 70, 111, 111, 66, 65, 208, 128, 82 }, "00C"); }
    public bool Test4() { return PositiveTestString(Encoding.UTF8, 7, new byte[] { 195, 128, 110, 105, 109, 97, 204, 128, 108 }, "00D"); }
    public bool Test5() { return PositiveTestString(Encoding.UTF8, 10, new byte[] { 84, 101, 115, 116, 240, 144, 181, 181, 84, 101, 115, 116 }, "00E"); }
    public bool Test6() { return PositiveTestString(Encoding.UTF8, 15, new byte[] { 0, 84, 101, 10, 115, 116, 0, 9, 0, 84, 15, 101, 115, 116, 0 }, "00F"); }
    public bool Test7() { return PositiveTestString(Encoding.UTF8, 14, new byte[] { 196, 84, 101, 115, 116, 196, 196, 196, 176, 176, 84, 101, 115, 116, 176 }, "00G"); }
    public bool Test8() { return PositiveTestString(Encoding.UTF8, 8, new byte[] { 84, 101, 115, 116, 84, 101, 115, 116 }, "00H"); }
    public bool Test9() { return PositiveTestString(Encoding.UTF8, 1, new byte[] { 176 }, "00I"); }
    public bool Test10() { return PositiveTestString(Encoding.UTF8, 1, new byte[] { 196 }, "00J"); }
    public bool Test11() { return PositiveTestString(Encoding.UTF8, 6, new byte[] { 240, 144, 181, 181, 240, 144, 181, 181, 240, 144, 181, 181 }, "00K"); }
    public bool Test12() { return PositiveTestString(Encoding.UTF8, 1, new byte[] { 196, 176 }, "00L"); }
    public bool Test13() { return PositiveTestString(Encoding.UTF8, 7, new byte[] { 240, 240, 144, 181, 181, 240, 144, 181, 181, 240, 144, 240 }, "0A2"); }

  
    public bool Test40() { return PositiveTestString(Encoding.Unicode, 11, new byte[] { 84, 0, 101, 0, 115, 0, 116, 0, 83, 0, 116, 0, 114, 0, 105, 0, 110, 0, 103, 0, 45 }, "00A3"); }
    public bool Test41() { return PositiveTestString(Encoding.Unicode, 0, new byte[] { }, "00B3"); }
    public bool Test42() { return PositiveTestString(Encoding.Unicode, 7, new byte[] { 70, 0, 111, 0, 111, 0, 66, 0, 65, 0, 0, 4, 82, 0 }, "00C3"); }
    public bool Test43() { return PositiveTestString(Encoding.Unicode, 7, new byte[] { 192, 0, 110, 0, 105, 0, 109, 0, 97, 0, 0, 3, 108, 0 }, "00D3"); }
    public bool Test44() { return PositiveTestString(Encoding.Unicode, 10, new byte[] { 84, 0, 101, 0, 115, 0, 116, 0, 3, 216, 117, 221, 84, 0, 101, 0, 115, 0, 116, 0 }, "00E3"); }
    public bool Test45() { return PositiveTestString(Encoding.Unicode, 15, new byte[] { 0, 0, 84, 0, 101, 0, 10, 0, 115, 0, 116, 0, 0, 0, 9, 0, 0, 0, 84, 0, 15, 0, 101, 0, 115, 0, 116, 0, 0, 0 }, "00F3"); }
    public bool Test46() { return PositiveTestString(Encoding.Unicode, 8, new byte[] { 84, 0, 101, 0, 115, 0, 116, 0, 84, 0, 101, 0, 115, 0, 116, 0 }, "00G3"); }
    public bool Test47() { return PositiveTestString(Encoding.Unicode, 9, new byte[] { 84, 0, 101, 0, 115, 0, 116, 0, 84, 0, 101, 0, 115, 0, 116, 0, 117, 221 }, "00H3"); }
    public bool Test48() { return PositiveTestString(Encoding.Unicode, 9, new byte[] { 84, 0, 101, 0, 115, 0, 116, 0, 84, 0, 101, 0, 115, 0, 116, 0, 3, 216 }, "00I3"); }
    public bool Test49() { return PositiveTestString(Encoding.Unicode, 2, new byte[] { 3, 216, 84 }, "00J3"); }
    public bool Test50() { return PositiveTestString(Encoding.Unicode, 6, new byte[] { 3, 216, 117, 221, 3, 216, 117, 221, 3, 216, 117, 221 }, "00K3"); }
    public bool Test51() { return PositiveTestString(Encoding.Unicode, 1, new byte[] { 48, 1 }, "00L3"); }
    public bool Test52() { return PositiveTestString(Encoding.Unicode, 4, new byte[] { 3, 216, 117, 221, 3, 216, 117, 221 }, "0A23"); }

    public bool Test53() { return PositiveTestString(Encoding.BigEndianUnicode, 11, new byte[] { 0, 84, 0, 101, 0, 115, 0, 116, 0, 83, 0, 116, 0, 114, 0, 105, 0, 110, 0, 103, 0 }, "00A4"); }
    public bool Test54() { return PositiveTestString(Encoding.BigEndianUnicode, 0, new byte[] { }, "00B4"); }
    public bool Test55() { return PositiveTestString(Encoding.BigEndianUnicode, 8, new byte[] { 0, 70, 0, 111, 0, 111, 0, 66, 0, 65, 4, 0, 0, 82, 70 }, "00C4"); }
    public bool Test56() { return PositiveTestString(Encoding.BigEndianUnicode, 7, new byte[] { 0, 192, 0, 110, 0, 105, 0, 109, 0, 97, 3, 0, 0, 108 }, "00D4"); }
    public bool Test57() { return PositiveTestString(Encoding.BigEndianUnicode, 10, new byte[] { 0, 84, 0, 101, 0, 115, 0, 116, 216, 3, 221, 117, 0, 84, 0, 101, 0, 115, 0, 116 }, "00E4"); }
    public bool Test58() { return PositiveTestString(Encoding.BigEndianUnicode, 16, new byte[] { 0, 0, 0, 84, 0, 101, 0, 10, 0, 115, 0, 116, 0, 0, 0, 9, 0, 0, 0, 84, 0, 15, 0, 101, 0, 115, 0, 116, 0, 0, 0 }, "00F4"); }
    public bool Test59() { return PositiveTestString(Encoding.BigEndianUnicode, 8, new byte[] { 0, 84, 0, 101, 0, 115, 0, 116, 0, 84, 0, 101, 0, 115, 0, 116 }, "00G4"); }
    public bool Test60() { return PositiveTestString(Encoding.BigEndianUnicode, 9, new byte[] { 0, 84, 0, 101, 0, 115, 0, 116, 0, 84, 0, 101, 0, 115, 0, 116, 221, 117 }, "00H4"); }
    public bool Test61() { return PositiveTestString(Encoding.BigEndianUnicode, 9, new byte[] { 0, 84, 0, 101, 0, 115, 0, 116, 0, 84, 0, 101, 0, 115, 0, 116, 216, 3 }, "00I4"); }
    public bool Test62() { return PositiveTestString(Encoding.BigEndianUnicode, 2, new byte[] { 216, 3, 48 }, "00J4"); }
    public bool Test63() { return PositiveTestString(Encoding.BigEndianUnicode, 6, new byte[] { 216, 3, 221, 117, 216, 3, 221, 117, 216, 3, 221, 117 }, "00K4"); }
    public bool Test64() { return PositiveTestString(Encoding.BigEndianUnicode, 1, new byte[] { 1, 48 }, "00L4"); }
    public bool Test65() { return PositiveTestString(Encoding.BigEndianUnicode, 4, new byte[] { 216, 3, 221, 117, 216, 3, 221, 117 }, "0A24"); }

    // Negative Tests
    public bool Test76() { return NegativeTestChars(new UTF8Encoding(), null, typeof(ArgumentNullException), "00O"); }
  
    public bool Test79() { return NegativeTestChars(new UnicodeEncoding(), null, typeof(ArgumentNullException), "00O3"); }
    public bool Test80() { return NegativeTestChars(new UnicodeEncoding(true, false), null, typeof(ArgumentNullException), "00O4"); }

    public bool Test81() { return NegativeTestChars2(new UTF8Encoding(), null, 0, 0, typeof(ArgumentNullException), "00P"); }
    public bool Test82() { return NegativeTestChars2(new UTF8Encoding(), new byte[] { 0, 0 }, -1, 1, typeof(ArgumentOutOfRangeException), "00P"); }
    public bool Test83() { return NegativeTestChars2(new UTF8Encoding(), new byte[] { 0, 0 }, 1, -1, typeof(ArgumentOutOfRangeException), "00Q"); }
    public bool Test84() { return NegativeTestChars2(new UTF8Encoding(), new byte[] { 0, 0 }, 0, 10, typeof(ArgumentOutOfRangeException), "00R"); }
    public bool Test85() { return NegativeTestChars2(new UTF8Encoding(), new byte[] { 0, 0 }, 3, 0, typeof(ArgumentOutOfRangeException), "00S"); }

  
    public bool Test96() { return NegativeTestChars2(new UnicodeEncoding(), null, 0, 0, typeof(ArgumentNullException), "00P3"); }
    public bool Test97() { return NegativeTestChars2(new UnicodeEncoding(), new byte[] { 0, 0 }, -1, 1, typeof(ArgumentOutOfRangeException), "00P3"); }
    public bool Test98() { return NegativeTestChars2(new UnicodeEncoding(), new byte[] { 0, 0 }, 1, -1, typeof(ArgumentOutOfRangeException), "00Q3"); }
    public bool Test99() { return NegativeTestChars2(new UnicodeEncoding(), new byte[] { 0, 0 }, 0, 10, typeof(ArgumentOutOfRangeException), "00R3"); }
    public bool Test100() { return NegativeTestChars2(new UnicodeEncoding(), new byte[] { 0, 0 }, 3, 0, typeof(ArgumentOutOfRangeException), "00S3"); }

    public bool Test101() { return NegativeTestChars2(new UnicodeEncoding(true, false), null, 0, 0, typeof(ArgumentNullException), "00P4"); }
    public bool Test102() { return NegativeTestChars2(new UnicodeEncoding(true, false), new byte[] { 0, 0 }, -1, 1, typeof(ArgumentOutOfRangeException), "00P4"); }
    public bool Test103() { return NegativeTestChars2(new UnicodeEncoding(true, false), new byte[] { 0, 0 }, 1, -1, typeof(ArgumentOutOfRangeException), "00Q4"); }
    public bool Test104() { return NegativeTestChars2(new UnicodeEncoding(true, false), new byte[] { 0, 0 }, 0, 10, typeof(ArgumentOutOfRangeException), "00R4"); }
    public bool Test105() { return NegativeTestChars2(new UnicodeEncoding(true, false), new byte[] { 0, 0 }, 3, 0, typeof(ArgumentOutOfRangeException), "00S4"); }

    public bool PositiveTestString(Encoding enc, int expected, byte[] bytes, string id)
    {
        bool result = true;
        TestFramework.BeginScenario(id + ": Getting bytes for " + TestLibrary.Utilities.ByteArrayToString(bytes) + " with encoding " + enc.WebName);
        try
        {
            int output = enc.GetCharCount(bytes);
            if (expected != output)
            {
                result = false;
                TestFramework.LogError("001", "Error in " + id + ", unexpected comparison result. Actual chars " + output + ", Expected: " + expected);
            }
        }
        catch (Exception exc)
        {
            result = false;
            TestFramework.LogError("002", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
        }
        return result;
    }

    public bool NegativeTestChars(Encoding enc, byte[] bytes, Type excType, string id)
    {
        bool result = true;
        TestFramework.BeginScenario(id + ": Getting bytes with encoding " + enc.WebName);
        try
        {
            int output = enc.GetCharCount(bytes);
            result = false;
            TestFramework.LogError("007", "Error in " + id + ", Expected exception not thrown. Actual chars " + output + ", Expected exception type: " + excType.ToString());
        }
        catch (Exception exc)
        {
            if (exc.GetType() != excType)
            {
                result = false;
                TestFramework.LogError("008", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
            }
        }
        return result;
    }

    public bool NegativeTestChars2(Encoding enc, byte[] bytes, int index, int count, Type excType, string id)
    {
        bool result = true;
        TestFramework.BeginScenario(id + ": Getting bytes with encoding " + enc.WebName);
        try
        {
            int output = enc.GetCharCount(bytes, index, count);
            result = false;
            TestFramework.LogError("009", "Error in " + id + ", Expected exception not thrown. Actual chars " + output + ", Expected exception type: " + excType.ToString());
        }
        catch (Exception exc)
        {
            if (exc.GetType() != excType)
            {
                result = false;
                TestFramework.LogError("010", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
            }
        }
        return result;
    }
}
