#include <iostream>

using namespace std;
bool pali(int x)
{
    int n[7],a,s;
    int i=0;
    while(x)
    {
        a=x%10;
        x=x/10;
        n[i]=a;
        i++;
    }
    s=i/2;
    bool flag=true;
    for(int k=0; k<s; k++)
    {
        if(n[k]!=n[i-1-k])
        {

        }
    }
}
int main()
{
    int n;
    cin>>n;
    for(int a=n; a>0; a--)
    {
        for(int b=n; b>0; b--)
        {
            cout<<a*b<<endl;
            if(pali(a*b))
            {
                cout<<a*b<<endl;
                return 0;
            }
        }
    }
}
