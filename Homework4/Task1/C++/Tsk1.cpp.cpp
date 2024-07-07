#include <bits/stdc++.h>
using namespace std;
void ValidatePassword(string s)
{
	long sayi=0,sayd=0;
	if(s.size()<8 || isupper(s[0])==false || isdigit(s[0])==true)
	{
		cout<<"false";
	}
	else
	{
		for(int i=0;i<s.size();i++)
		{
			if(isdigit(s[i])==true)
			{
				sayd++;
			}
			if(isdigit(s[i])==false && isalpha(s[i])==false)
			{
				sayi++;
			}
		}
		if(sayd>=1 && sayi>=1)
		{
			cout<<"true";
		}
		else
		{
			cout<<"false";
		}
	}}
int main()
{
	string k;
	cin>>k;
	ValidatePassword(k);
}

