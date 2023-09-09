﻿'use server'

import {Auction, PagedResult} from "@/types";

export async function getData(query: string): Promise<PagedResult<Auction>> {
  const response = await fetch(`http://localhost:6001/search${query}`)
  if (!response.ok) throw new Error(response.statusText)
  return await response.json()
}

export async function UpdateAuctionTest() {
  const data = {
    description: "test123",
    serialNumber: "test123",
  }
  
  const response = await fetch(`http://localhost:6001/auctions/ec6c830a-b6e9-4a07-8560-533bc08e3d07`, {
    method: 'PUT',
    headers: {},
    body: JSON.stringify(data)
  })
  
  if (!response.ok) return {status: response.status, message: response.statusText}
  
  return response.statusText
}