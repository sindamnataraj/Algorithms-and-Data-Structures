using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public class Graph
    {
        private int vCount;
        private int edgeCount;
        private List<int>[] Adj;

        public Graph() {
        }

        public Graph(int v)
        {
            if (v <= 0) throw new Exception("Invalid Vertices");
            vCount = v;
            Adj = new List<int>[v];
        }
 
        public void AddEdge(int u,int v) {
            Adj[u].Add(v);
        }




        


    }
}
