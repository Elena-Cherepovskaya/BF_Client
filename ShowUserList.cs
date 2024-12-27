namespace BF_Client
{
    public class ShowUserList  : ShowList<User, UserAdd>
    {
        public ShowUserList(DataGridView dataGridView) : base(dataGridView, "/api/User") {}

        protected override string GetAddTitle() => "Пользователь";

        protected override UserAdd CreateNewElement() => new();
    }
}
