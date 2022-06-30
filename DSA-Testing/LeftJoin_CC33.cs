using System;
using Xunit;
using System.Collections;
using data_structures_and_algorithms_1.hashmap_left_join;
using System.Collections.Generic;

namespace DSA_Testing
{
    public class LeftJoin_CC33
    {
        [Fact]
        public void Test1()
        {
            Hashtable t1 = new Hashtable();
            Hashtable t2 = new Hashtable();

            t1.Add("diligent", "employed");
            t1.Add("fond", "enamored");
            t1.Add("guide", "usher");
            t1.Add("outfit", "garb");
            t1.Add("wrath", "anger");

            t2.Add("diligent", "idle");
            t2.Add("fond", "averse");
            t2.Add("guide", "follow");
            t2.Add("flow", "jam");
            t2.Add("wrath", "delight");

            var result = Hashmap.LeftJoin(t1, t2);

            var expected_result = new List<string>
            {
                "diligent,employed,idle",
                "wrath,anger,delight",
                "fond,enamored,averse",
                "outfit,garb,null",
                "guide,usher,follow"
            };

            bool flag = true;
            foreach (string e in expected_result)
            {
                if (!result.Contains(e))
                    flag = false;
            }

            Assert.True(flag);
        }


        [Fact]
        public void Test2()
        {
            Hashtable t1 = new Hashtable();
            Hashtable t2 = new Hashtable();

            t1.Add("diligent", "employed");
            t1.Add("fond", "enamored");
            t1.Add("guide", "follow");

            t2.Add("diligent", "idle");
            t2.Add("fond", "enamored");

            var result = Hashmap.LeftJoin(t1, t2);

            var expected_result = new List<string>
            {
                "guide,follow,null",
                "diligent,employed,idle",
                "fond,enamored,enamored"
            };

            bool flag = true;
            foreach (string e in expected_result)
            {
                if (!result.Contains(e))
                    flag = false;
            }

            Assert.True(flag);
        }

        [Fact]
        public void Test3()
        {
            Hashtable t1 = new Hashtable();
            Hashtable t2 = new Hashtable();

            t1.Add("diligent", "employed");
            t1.Add("fond", "enamored");
            t1.Add("guide", "follow");

            var result = Hashmap.LeftJoin(t1, t2);

            var expected_result = new List<string>
            {
                "diligent,employed,null",
                "fond,enamored,null",
                "guide,follow,null",
            };

            bool flag = true;
            foreach (string e in expected_result)
            {
                if (!result.Contains(e))
                    flag = false;
            }

            Assert.True(flag);
        }
    }
}
