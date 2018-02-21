#include <cstdlib>
#include <ctime>
#include <iostream>

using namespace std;

int main()
{

 int array[20],br=0;

 srand((unsigned)time(0));

    for(int i=0; i<20; i++){
        array[i] = (rand()%100)+1;
        if(array[i]>0 && array[i]<100)
        {
            br++;
        }
 }
 cout<<"Total numbers between 1 and 100: "<<br<<endl;
}
