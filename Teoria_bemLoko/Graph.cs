using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_bemLoko
{
    class Graph
    {
        Queue<Node> q = new Queue<Node>();
        Stack<Node> s = new Stack<Node>();
        List<Node> nodes = new List<Node>();
        List<Node> ordem = new List<Node>();
        Node n = new Node();

        public List<Node> DepthFirstSearch(string begin)
        {
            ordem.Clear();
            n = Find(begin);
            n.Visited = true;
            s.Push(n);
            ordem.Add(n);

            while (s.Count != 0)
            {
                n = s.Pop();
                foreach (var m in n.Edges)
                {
                    if (m.To.Visited == false)
                    {
                        m.To.Visited = true;
                        s.Push(m.To);
                        ordem.Add(m.To);
                        m.To.Parent = n;
                    }
                }
            }
            return ordem;
        }

        public void AddNode(string name, object info)
        {
            Node n = new Node();
            n.Name = name;
            n.Info = info;
            nodes.Add(n);
        }

        public void AddEdge(string nameFrom, string nameTo, int cost)
        {
            Node f, t;
            f = Find(nameFrom);
            t = Find(nameTo);
            f.AddEdge(t, cost);

        }
        private Node Find(string name)
        {
            foreach (var no in nodes)
            {
                if (no.Name == name)
                    return no;
            }

            return null;
        }
    }
}
