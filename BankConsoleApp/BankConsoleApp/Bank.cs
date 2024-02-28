using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    public class Bank
    {
        // 
        // Collezione di conti correnti
        //
        private List<BankAccount> _accounts;

        //
        // Costruttore
        //
        public Bank()
        {
            // DA FARE: Inizializza la collezione di conti correnti
            _accounts = new List<BankAccount>();
        }

        //
        // Metodi pubblici
        //
        
        public List<BankAccount> GetAccounts() 
        { 
            return _accounts;
        }

        public void AddAccount(BankAccount account)
        {
            // DA FARE: verificare che l'account non sia nullo
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account), "Account cannot be null");
            }

            // DA FARE: Aggiungi un conto corrente alla collezione
            _accounts.Add(account);
        }

        public void RemoveAccount(BankAccount account)
        {
            // DA FARE: verificare che l'account non sia nullo
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account), "Account cannot be null");
            }

            // DA FARE: verificare che l'account esista nella collezione
            if (!_accounts.Contains(account))
            {
                throw new InvalidOperationException("Account does not exist in the bank");
            }

            // DA FARE: Rimuovi un conto corrente dalla collezione
            _accounts.Remove(account);
        }

        public double GetTotalBalance()
        {
            // DA FARE: Calcola il saldo totale di tutti i conti correnti
            double totalBalance = 0;
            foreach (BankAccount account in _accounts)
            {
                totalBalance += account.GetBalance();
            }
            return totalBalance;
        }

    }
}

