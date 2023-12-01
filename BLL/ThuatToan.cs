using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord;
using Accord.IO;
using System.IO;
using Accord.MachineLearning;
using Accord.Statistics.Analysis;

namespace BLL
{
    public class ThuatToan
    {
        DecisionTree tree;
        int[][] inputs;
        int[] outputs;
        Codification codebook;
        public void readDecisionTree(DataTable data, int slHieuSuat, int slCamera, int slPin, int slTanSo)
        {
            codebook = new Codification(data);

            // Translate our training data into integer symbols using our codebook:
            DataTable symbols = codebook.Apply(data);

            // Extracting inputs and outputs
            inputs = symbols.AsEnumerable()
            .Select(row => new int[]
            {
                Convert.IsDBNull(row["HieuSuat"]) ? 0 : Convert.ToInt32(row["HieuSuat"]),
                Convert.IsDBNull(row["Camera"]) ? 0 : Convert.ToInt32(row["Camera"]),
                Convert.IsDBNull(row["Pin"]) ? 0 : Convert.ToInt32(row["Pin"]),
                Convert.IsDBNull(row["TanSo"]) ? 0 : Convert.ToInt32(row["TanSo"]),
            })
            .ToArray();


            outputs = symbols.AsEnumerable()
            .Select(row => Convert.IsDBNull(row["idSanPham"]) ? 0 : Convert.ToInt32(row["idSanPham"]))
            .ToArray();


            // For this task, in which we have only categorical variables, the simplest choice 
            // to induce a decision tree is to use the ID3 algorithm by Quinlan. Let’s do it:

            // Create a teacher ID3 algorithm
            var id3learning = new ID3Learning()
            {
                // Now that we already have our learning input/ouput pairs, we should specify our
                // decision tree. We will be trying to build a tree to predict the last column, entitled
                // “PlayTennis”. For this, we will be using the “Outlook”, “Temperature”, “Humidity” and
                // “Wind” as predictors (variables which will we will use for our decision). Since those
                // are categorical, we must specify, at the moment of creation of our tree, the
                // characteristics of each of those variables. So:

                new DecisionVariable("HieuSuat", slHieuSuat), // 3 possible values (Hot, mild, cool)  
                new DecisionVariable("Camera",    slCamera), // 2 possible values (High, normal)    
                new DecisionVariable("Pin",        slPin),  // 2 possible values (Weak, strong) 
                new DecisionVariable("TanSo",        slTanSo),

                // Note: It is also possible to create a DecisionVariable[] from a codebook:
                // DecisionVariable[] attributes = DecisionVariable.FromCodebook(codebook);
            };

            // Learn the training instances!
            tree = id3learning.Learn(inputs, outputs);


        }
        public String goiY(AIDTO list)
        {
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

            // The tree can now be queried for new examples through 
            // its decide method. For example, we can create a query

            int[] query = codebook.Transform(new[,]
            {
                { "HieuSuat", list.HieuSuat   },
                { "Camera",    list.Camera   },
                { "Pin",    list.Pin },
                { "TanSo",    list.TanSo   },
            });

            // And then predict the label using
            int predicted = tree.Decide(query);  // result will be 0

            // We can translate it back to strings using
            string answer = codebook.Revert("idSanPham", predicted); // Answer will be: "No"
            return answer;
        }
    }
}
