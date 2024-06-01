//https://exercism.org/tracks/csharp/exercises/faceid-2

namespace ExercismChallengesConsoleApp
{

    public class FacialFeatures
    {
        public string EyeColor { get; }
        public decimal PhiltrumWidth { get; }
        

        public FacialFeatures(string eyeColor, decimal philtrumWidth)
        {
            EyeColor = eyeColor;
            PhiltrumWidth = philtrumWidth;
        }
        // TODO: implement equality and GetHashCode() methods

        public override bool Equals(object? obj)
        {
            if (obj is FacialFeatures other)
            {
                return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EyeColor, PhiltrumWidth);
        }

    }

    public class Identity
    {
        public string Email { get; }
        public FacialFeatures FacialFeatures { get; }

        public Identity(string email, FacialFeatures facialFeatures)
        {
            Email = email;
            FacialFeatures = facialFeatures;
        }
        // TODO: implement equality and GetHashCode() methods
        public override bool Equals(object? obj)
        {
            if (obj is Identity other)
            {
                return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Email, FacialFeatures.GetHashCode);
        }
    }

    public class Authenticator
    {
        public List<Identity> Identities { get; } = new List<Identity>();
        public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
        {
            return faceA.Equals(faceB);
        }

        public bool IsAdmin(Identity identity)
        {
            var adminFF = new FacialFeatures("green", 0.9m);
            var adminIdent = new Identity("admin@exerc.ism", adminFF);
           return identity.Equals(adminIdent);
        }

        public bool Register(Identity identity)
        {
            if (Identities.Contains(identity))
                return false;
            else
            {
                Identities.Add(identity);
                return true;
            }
        }

        public bool IsRegistered(Identity identity)
        {
           return Identities.Contains(identity);
        }

        public static bool AreSameObject(Identity identityA, Identity identityB)
        {
            return identityA.GetHashCode() == identityB.GetHashCode();
        }
    }

}
