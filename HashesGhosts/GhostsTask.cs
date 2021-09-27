using System;
using System.Text;

namespace hashes
{
	public class GhostsTask : 
		IFactory<Document>, IFactory<Vector>, IFactory<Segment>, IFactory<Cat>, IFactory<Robot>, 
		IMagic

	{
        public byte[] content;
        Document document;
        Vector vector = new Vector(1, 2);
        Segment segment = new Segment(new Vector(0, 0), new Vector(1, 1));
        Cat cat = new Cat("Barsik", "British", DateTime.Now);
        Robot robot = new Robot("IamNotRobot");
        public GhostsTask()
        { 
            var encoding = Encoding.ASCII;
            content = encoding.GetBytes("Hello World");
            document = new Document("Unnamed1", encoding, content);
        }

        public void DoMagic()
        { // портим всё, до чего можем незаметно дотянуться
            for (var i = 0; i < content.Length; i++)
                ++content[i];
            vector.Add(new Vector(5, 6));
            segment.End.Add(new Vector(7, 8));
            cat.Rename("CatName2");
            Robot.BatteryCapacity /= 2;
        }
        public Document Create()
        {
            return document;
        }

        Vector IFactory<Vector>.Create()
		{
			return vector;
		}

		Segment IFactory<Segment>.Create()
		{
			return segment;
		}

        Cat IFactory<Cat>.Create()
        {
            return cat;
        }

        Robot IFactory<Robot>.Create()
        {
            return robot;
        }
    }
}