#include<iostream>
#include<ctime>
using namespace std;

void randomPopulate(int x[], int y)
{
    for(int i=0; i<y; i++)
    {
        x[i]=rand()%100+1;
    }
}

void display(int x[], int y)
{
    for(int i=0; i<y; i++)
    {
        cout<<x[i]<<", ";
    }
    cout<<"\b\b "<<endl;
}

void arraySort(int x[], int y)
{
    int temp;
    for(int i=0; i<y; i++)
    {
        for(int j=i+1; j<y; j++)
        {
            if(x[j]<x[i])
            {
                temp=x[i];
                x[i]=x[j];
                x[j]=temp;
            }
        }
    }
}

void arrayMerge(int x[], int y[], int z[], int n1, int n2, int n3)
{
    int placeA=0;
    int placeB=0;

    for(int i=0; i<n3; i++)
    {
        if(placeA>=n1)
        {
            z[i]=y[placeB];
            placeB++;
        }
        else if(placeB>=n2)
        {
            z[i]=x[placeA];
            placeA++;
        }
        else if(x[placeA]<=y[placeB])
        {
            z[i]=x[placeA];
            placeA++;
        }
        else if(y[placeB]<=x[placeA])
        {
            z[i]=y[placeB];
            placeB++;
        }
    }
}

int main()
{
    int num1, num2, num3;

    cout<<"How many elements in the first Array? ";
    cin>>num1;

    cout<<"How many elements in the second Array? ";
    cin>>num2;

    srand(time(0));

    int A[num1];
    randomPopulate(A, num1);
    cout<<"Elements in 'A': ";
    display(A, num1);

    int B[num2];
    randomPopulate(B, num2);
    cout<<"Elements in 'B': ";
    display(B, num2);

    cout<<"Sorted Elements in 'A': ";
    arraySort(A, num1);
    display(A, num1);

    cout<<"Sorted Elements in 'B': ";
    arraySort(B, num2);
    display(B, num2);

    num3=num1+num2;
    int C[num3];
    cout<<"Elements in 'C': ";
    arrayMerge(A, B, C, num1, num2, num3);
    display(C, num3);

    return 0;
}
