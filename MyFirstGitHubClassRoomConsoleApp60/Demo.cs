using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        public int _id;
        public string _name;
        public string _title;
        public string _description;
        public string _url;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Description
        {
            get => _description;
            set => _description = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Url
        {
            get => _url;
            set => _url = value ?? throw new ArgumentNullException(nameof(value));
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Title)}: {Title}, {nameof(Description)}: {Description}, {nameof(Url)}: {Url}";
        }
    }
}
