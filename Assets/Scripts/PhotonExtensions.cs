using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

using Photon.Pun;
using Photon.Realtime;

public static class PhotonExtensions {

    private static readonly Dictionary<string, string> SPECIAL_PLAYERS = new() {
        ["080bf7071cde398203f8ebe86171b6461c697441baa10f69e25d7adf3c17e606"] = "Cubby",
        ["e22b0af382ee827f220519b31b15f58113885b8bf86c1917875e871fee3806cf"] = "AutumnLeaf",
        ["3d4c251a2b0a78243b49922256fb18cfeee9c13cf5f408fead6c8bb6cab459eb"] = "MiiBumm",
        ["5328dab6e3958c1a6769f07bcb897054dd1b40a757adeaa5598559ce4e969ddc"] = "Grape",
        ["514e957b394bef3143b5d026b309d60846ed5715d155a9c34a252719892c2ccf"] = "Player1214", //Cubby in Unity editor
        ["091a6fec86285fb1be3689a1b9c87d7449bcd7422f2d12874ed3489b5705e8c1"] = "justarobotidk",
        ["cf8be01bd00c5d0f333de80ceda04d53f25b862d33ed9900161857a354f4070c"] = "MvLWalterWhite",
        ["ef41269dca2cd7cb890ff7539ac5020f0a0f8445f7b072722bf514a7484133a0"] = "ThePooHacker", // Idk who this is wowza
        ["a4ffd0446071e92139d1cbbd813888342fa055756cc236c3362f73d5943ae29a"] = "vic" // bowswer from fortnite
    };

    private static readonly Dictionary<string, string> POOPIE_PLAYERS = new()
    {
        ["f9f44ec0da6bd789788cd269c9a445ee4151297177bbb7d62b495cf0b4d485eb"] = "SMYT",
        ["514e957b394bef3143b5d026b309d60846ed5715d155a9c34a252719892c2ccf"] = "Player1214",
        ["292421023f141f176bd6e4027e4dfa5306bc7699dbc5d9bb22f039e975b83de1"] = "Vinci2000",
        ["b97e2ab7cd07e3bc8d926835405c4925a742f70b5c435ea7247f126d56a61aec"] = "DisVeka",
        ["4bd776de218e794f09e91c894741a99739c7a0742640815df6e48e9064633c14"] = "NewbieGonzalez",
        ["66daad1fc96d80a0e0c3214992b4eba9d36fa8ff81b736d28af690dec1b84e10"] = "4Axion",
        ["6e12b5b05f7f2f9c1f75d439b51c38a033478e4b8d096f20e65797e80d35124b"] = "Snowpea",
        ["0c9cbc9f31104d99842f19c939d5eac1c4a5eb5af35197793add37ffd0810b2d"] = "Meme Stealer", //no kirby for you
        ["47c05f42e970501d7a43e343512a1390ee858ff83394b04f9a51cd7f4d437011"] = "Fake MiiBumm", //i found you faker!
        ["58f96bec35c07f1044b483cc1cfc237c438511b685ef6ad439aa807a0650c9f0"] = "Stupid fucking blind bitch playing on the webGL version",
        ["94aa95e97f31ff7ba35b8d1e145e07281ec92d76d982b8031862037af64d70d1"] = "luigi", //from mario
    };

    private static readonly Dictionary<string, string> MR_CLEAN_PLAYERS = new()
    {
        ["unused"] = "unused",
    };

    public static bool IsMineOrLocal(this PhotonView view) {
        return !view || view.IsMine;
    }

    public static bool HasRainbowName(this Player player) {
        if (player == null || player.UserId == null)
            return false;

        byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(player.UserId));
        StringBuilder sb = new();
        foreach (byte b in bytes)
            sb.Append(b.ToString("X2"));

        string hash = sb.ToString().ToLower();
        return SPECIAL_PLAYERS.ContainsKey(hash) && player.NickName == SPECIAL_PLAYERS[hash];
    }

        public static bool HasPoopieName(this Player player) {
        if (player == null || player.UserId == null)
            return false;

        byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(player.UserId));
        StringBuilder sb = new();
        foreach (byte b in bytes)
            sb.Append(b.ToString("X2"));

        string hash = sb.ToString().ToLower();
        return POOPIE_PLAYERS.ContainsKey(hash);
    }

    public static bool HasTakenShower(this Player player)
    {
        if (player == null || player.UserId == null)
            return false;

        byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(player.UserId));
        StringBuilder sb = new();
        foreach (byte b in bytes)
            sb.Append(b.ToString("X2"));

        string hash = sb.ToString().ToLower();
        return MR_CLEAN_PLAYERS.ContainsKey(hash);
    }

    //public static void RPCFunc(this PhotonView view, Delegate action, RpcTarget target, params object[] parameters) {
    //    view.RPC(nameof(action), target, parameters);
    //}
}