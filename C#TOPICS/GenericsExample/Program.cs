
using GenericsExample;

Coordinate<string, int> st1 = new Coordinate<string, int>();

st1.Name = "sumi";
st1.Roll = 1;
st1.Dosomething<int, double>("potol", 3221, 23.2);