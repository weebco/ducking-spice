using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Equipments.items
    {
    class Wallet : Items
    {
        public int gold = 0;
        public int maxGold = 0;

        public enum WalletTypes
        {
            LEATHER,
            OVERSIZE,
            JEWISH
        }

        public WalletTypes walletType;

        public Wallet(WalletTypes newWalletType, int money)
        {
            gold += money;
            walletType = newWalletType;
            if (newWalletType == WalletTypes.LEATHER)
            {
                maxGold = 1000;
            }
            else if (newWalletType == WalletTypes.OVERSIZE)
            {
                maxGold = 5000;
            }
            else
            {
                maxGold = 10000;
            }
            isLootable = true;
        }

    }
    }
