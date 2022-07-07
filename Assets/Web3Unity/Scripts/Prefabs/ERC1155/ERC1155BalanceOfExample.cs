using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    public GameObject FlappyAmarillo;

    async public void CheckNFT()
    {
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0xa871d1a0D2aa66A568181D967F09A9c531881942";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "1";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if(balanceOf > 0)
        {
            FlappyAmarillo.SetActive(true);
        }
    }

    private void Update()
    {
        SceneManager.LoadScene(3);
    }
}
