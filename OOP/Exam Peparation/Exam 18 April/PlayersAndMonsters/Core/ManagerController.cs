namespace PlayersAndMonsters.Core
{
    using System.Text;
    using Contracts;
    using Common;
    using Models.BattleFields.Contracts;
    using Models.Cards;
    using Models.Players;
    using Models.Players.Contracts;
    using Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        private IPlayerRepository playerRepository;
        private ICardRepository cardRepository;
        private IBattleField battleField;
        private IPlayer player;

        public ManagerController(IPlayerRepository playerRepository, ICardRepository cardRepository, IBattleField battleField)
        {
            this.playerRepository = playerRepository;
            this.cardRepository = cardRepository;
            this.battleField = battleField;
        }

        public string AddPlayer(string type, string username)
        {
            if (type == "Beginner")
            {
                IPlayer player = new Beginner(cardRepository, username);
                playerRepository.Add(player);
            }
            else if (type == "Advanced")
            {
                IPlayer player = new Advanced(cardRepository, username);
                playerRepository.Add(player);
            }
            return string.Format(ConstantMessages.SuccessfullyAddedPlayer, type, username);
        }

        public string AddCard(string type, string name)
        {
            if (type == "Magic")
            {
                Card card = new MagicCard(name);
                cardRepository.Add(card);
            }
            else if (type == "Trap")
            {
                Card card = new TrapCard(name);
                cardRepository.Add(card);
            }
            return string.Format(ConstantMessages.SuccessfullyAddedCard, type, name);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            var player = playerRepository.Find(username);
            var card =  cardRepository.Find(cardName);
            player.CardRepository.Add(card);

            return string.Format(ConstantMessages.SuccessfullyAddedPlayerWithCards, cardName, username);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            var attackPlayer = playerRepository.Find(attackUser);
            var enemyPlayer = playerRepository.Find(enemyUser);

            battleField.Fight(attackPlayer, enemyPlayer);

            return string.Format(ConstantMessages.FightInfo, attackPlayer.Health, enemyPlayer.Health);
        }

        public string Report()
        {
            var sb = new StringBuilder();

            foreach (var player in playerRepository.Players)
            {
                sb.AppendLine(string.Format(ConstantMessages.PlayerReportInfo, player.Username, player.Health, player.CardRepository.Count));

                foreach (var card in player.CardRepository.Cards)
                {
                    sb.AppendLine(string.Format(ConstantMessages.CardReportInfo, card.Name, card.DamagePoints));
                }

                sb.AppendLine(ConstantMessages.DefaultReportSeparator);
            }

            return sb.ToString().TrimEnd();

        }
    }
}
