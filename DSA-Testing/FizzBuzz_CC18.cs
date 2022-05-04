using data_structures_and_algorithms_1.trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA_Testing
{
    public class FizzBuzz_CC18
    {
        [Fact]
        public void Test1()
        {
            // building the tree
            Tree tree = new Tree();
            TreeNode n15 = new TreeNode("15");
            TreeNode n1 = new TreeNode("1");
            TreeNode n5 = new TreeNode("5");
            TreeNode n3 = new TreeNode("3");
            TreeNode n20 = new TreeNode("20");
            TreeNode n33 = new TreeNode("3");
            TreeNode n11 = new TreeNode("1");
            TreeNode n9 = new TreeNode("9");
            TreeNode n30 = new TreeNode("30");

            tree.Root = n15;

            n15.Children.Add(n1);
            n15.Children.Add(n5);
            n15.Children.Add(n3);

            n1.Children.Add(n20);
            n1.Children.Add(n33);

            n5.Children.Add(n11);

            n3.Children.Add(n30);
            n3.Children.Add(n9);

            // Get fizz buzz tree
            Tree fizzbuzz = tree.FizzBuzz();

            // convert 'fizzbuzz' to list of strings
            List<string> actual_fizzbuzz = new List<string>();
            
            foreach (var e in fizzbuzz.BFS())
            {
                actual_fizzbuzz.Add(e.Value);
            }

            // expected result
            List<string> expected_fizzbuzz = new List<string>
            {
                "FizzBuzz",
                "1",
                "Buzz",
                "Fizz",
                "Buzz",
                "Fizz",
                "1",
                "FizzBuzz",
                "Fizz"
            };

            Assert.Equal(expected_fizzbuzz, actual_fizzbuzz);
        }
    }
}
