#include <list>
#include <iostream>

using namespace std;
void a(int b, int c,int d,int e)
{
    list<int> numbers;
    numbers.push_front(c);
    numbers.push_front(b);
    numbers.push_back(d);
    numbers.push_back(e);
    list<int>::iterator it;
    it=numbers.begin();
    while(it!=numbers.end())
    {
        cout<<*it<<"_";
        it++;
    }
}
int main()
{
    a(2,3,4,5);
    cout<<a;
    cout<<endl;
       int i,n=4,j,buf;
       int a[4]={4,3,2,1};
       for(i=0;i<4;i++)
       for(i=0;i<n;i++)
       for(j=n-1;j >i;j--)
       if(a[j-1]>a[j])
       {
          buf=a[j-1];
          a[j-1]=a[j];
          a[j]=buf;
       }
        for(i=0;i< n;i++)
        cout<<a[i]<< "\n";
        return 0;


}
