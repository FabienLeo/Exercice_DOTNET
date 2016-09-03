﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    public class BankAccount
    {
        private string m_customerName;
        private bool m_frozen = false;
        private double m_balance;
        
        private BankAccount(){}

        // Constructeur
        public BankAccount(string CustomerName, double Balance)
        {
            m_balance = Balance;
            m_customerName = CustomerName;
        }

    	public string CustomerName
	    {
		    get { return m_customerName;}
	    }
	
        public double Balance
	    {
		    get { return m_balance;}
	    }

        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Acount frozen");
	        }
            if (amount>m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount<0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }

        public void Credit(double amount) 
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount<0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

        private void FreezeAccount() 
        {
            m_frozen = true;
        }

        private void UnFreezeAccount() 
        {
            m_frozen = false;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr Fabien GAUDRON", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Curent balance is {0}", ba.Balance);
            Console.ReadKey();

        }
    }
}