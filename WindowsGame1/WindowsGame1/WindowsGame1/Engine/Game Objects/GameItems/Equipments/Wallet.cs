using System;

namespace WindowsGame1.Engine.GameItems.Equipments
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

        public Wallet(String name, WalletTypes newWalletType, int money, Boolean isLootable) : base(isLootable, name)
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
